using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[CreateAssetMenu]
public class FigureConfig : ScriptableObject
{
    [SerializeField] private ColorGroup[] colorGroups;

    public string[] GroupIDs => colorGroups.Select(group => group.ID).ToArray();

    public string[] GetFigureIDs(string groupID)
    {
        var colorGroup = colorGroups.FirstOrDefault(group => group.ID == groupID);
        return colorGroup == null ? null : colorGroup.FigureIDs;
    }

    public FigureInfo GetFigureInfo(string id)
    {
        foreach (var colorGroup in colorGroups)
        {
            var figure = colorGroup.GetFigureInfo(id);
            if (figure != null) return figure;
        }
        return null;
    }
}