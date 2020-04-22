using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Saber : MonoBehaviour
{
    private Vector3 previousPos;
    public LayerMask layer;
    public AudioSource slice;
    private static int Heal;
    public static int Points;
    // Start is called before the first frame update
    void Start()
    {
        slice = GetComponent<AudioSource>();
        Points = 0;
    }

    // Update is called once per frame
    void Update()
    {

        Heal = DestroyBlock.Health;
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, 1, layer))
        {
            if (Vector3.Angle(transform.position - previousPos, hit.transform.up) > 130)
            {
                slice.Play();
                Destroy(hit.transform.gameObject);
                Heal += 5;
                Points += 2000;
                Debug.Log (Points);
                
            }

        }
        previousPos = transform.position;
    }
}
