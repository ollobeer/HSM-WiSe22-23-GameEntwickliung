using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerGoal : MonoBehaviour
{
    public GameObject Roboter;

    AudioSource audioData;

    private void OnTriggerEnter(Collider other){
        Debug.Log(gameObject.name + " hat das Ziel: " + other.name + "erreicht");

        if(other.name == Roboter.name){
            Debug.Log("Victory");
            

            audioData = GetComponent<AudioSource>();
            audioData.Play(0);
            Debug.Log("started");
        }
    }
}
