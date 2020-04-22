using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Starts : MonoBehaviour
{

    void OnTriggerStay(Collider obj)
    {
        Debug.Log("IS working");
        //Level Select
        if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger)) { 
            Debug.Log("work");
            if (obj.gameObject.layer == 12)
            {
                SceneManager.LoadScene(2);
            }
        }
        //Normal Scene
        if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
        {
            Debug.Log("work");
            if (obj.gameObject.layer == 20)
            {
                SceneManager.LoadScene(1);
            }
        }
        //Back To Main Screen
        if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
        {
            Debug.Log("work");
            if (obj.gameObject.layer == 19)
            {
                SceneManager.LoadScene(0);
            }
        }
        //Easy Level
        if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
        {
            Debug.Log("work");
            if (obj.gameObject.layer == 21)
            {
                SceneManager.LoadScene(3);
            }
        }
        //Hard Level
        if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
        {
            Debug.Log("work");
            if (obj.gameObject.layer == 22)
            {
                SceneManager.LoadScene(4);
            }
        }

    }

}
