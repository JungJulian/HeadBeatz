using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScoreUI : MonoBehaviour
{
    private static int realHeal;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        realHeal = DestroyBlock.Health;
        
        GetComponent<TextMesh>().text = "Health: " + (realHeal);
    }
}
