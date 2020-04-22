using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    public GameObject[] cubes;
    public Transform[] points;
    public float beat;
    private float timer;
    public float interval;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        if (interval > 0)
        {
            interval -= Time.deltaTime;
            if (timer > beat)
            {
                GameObject cube = Instantiate(cubes[Random.Range(0, 2)], points[Random.Range(0, 8)]);
                cube.transform.localPosition = Vector3.zero;
                cube.transform.Rotate(transform.forward, 90 * Random.Range(0, 4));
                timer -= beat;
            }
            timer += Time.deltaTime;

            
        }
        else
        {
            enabled = false;
        }
        
    }
    
}
