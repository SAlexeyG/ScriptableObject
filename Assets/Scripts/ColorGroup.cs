using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public enum Clr
{
    Light,
    Dark,

}

[CreateAssetMenu]
public class ColorGroup : ScriptableObject
{
    [SerializeField] private string id;
    [SerializeField] private FigureInfo[] figures;

    public string ID => id;
    public string[] FigureIDs => figures.Select(figure => figure.ID).ToArray();

    public FigureInfo GetFigureInfo(string id) =>
        figures.FirstOrDefault(figure => figure.ID == id);
}
