using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[CreateAssetMenu]
public class FieldConfig : ScriptableObject
{
    [System.Serializable]
    public class VectorArray
    {
        public Vector3[] row;
    }

    [SerializeField] private GameObject board;
    [SerializeField] private VectorArray[] field;

    public GameObject Board => board;
    public Vector3[][] Field => field.Select(i => i.row).ToArray();
}
