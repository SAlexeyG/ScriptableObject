using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[CreateAssetMenu]
public class LayoutConfig : ScriptableObject
{
    [System.Serializable]
    public class StringArray
    {
        public string[] row;
    }

    [SerializeField] private StringArray[] figureIDs;

    public string[][] Layout => figureIDs.Select(i => i.row).ToArray();
}
