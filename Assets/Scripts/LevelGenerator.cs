using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private FigureConfig figureConfig;
    [SerializeField] private FieldConfig fieldConfig;
    [SerializeField] private LayoutConfig layoutConfig;

    // Start is called before the first frame update
    void Start()
    {
        if (layoutConfig.Layout.Length > fieldConfig.Field.Length) return;
        if (layoutConfig.Layout[0].Length > fieldConfig.Field[0].Length) return;

        var layout = new List<string>();
        foreach (var l in layoutConfig.Layout)
            layout.AddRange(l);

        var field = new List<Vector3>();
        foreach (var f in fieldConfig.Field)
            field.AddRange(f);

        Instantiate(fieldConfig.Board, Vector3.zero, Quaternion.identity);

        for (int i = 0; i < layout.Count; i++)
        {
            if (layout[i] == string.Empty) continue;
            Instantiate(figureConfig
                .GetFigureInfo(layout[i]).Model, field[i], Quaternion.identity);
        }
    }
}
