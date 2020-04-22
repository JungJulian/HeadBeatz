using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsUI : MonoBehaviour
{
    private static int realPoints;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        realPoints = Saber.Points;
        GetComponent<TextMesh>().text = "Points: " + (realPoints);
    }
}
