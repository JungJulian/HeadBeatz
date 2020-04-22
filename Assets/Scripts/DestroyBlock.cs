using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyBlock : MonoBehaviour
{
    public static int Health = 100;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Health < 0)
        {
            Health = 0;
            SceneManager.LoadScene(0);
            Debug.Log("Hello You Have Dies");
            Health = 100;

        }
        if (Health > 100)
        {
            Health = 0;
        }

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Block")
        {
            Destroy(other.gameObject);
            Health-= 10;
        }
    }
}
