using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class FigureInfo : ScriptableObject
{
    [SerializeField] private string id;
    [SerializeField] private GameObject model;

    public string ID => id;
    public GameObject Model => model;
}
