using UnityEngine;
using System.Collections;

public class Hit_detection : MonoBehaviour {


    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Entered my domain!");
    }

    void OnCollisionStay(Collision col)
    {
        Debug.Log("Still in my domain!");
    }


}
