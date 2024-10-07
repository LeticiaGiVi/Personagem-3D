using System.Collections;
using System.Collections.Generic;
using UnityEngine.Playables;
using UnityEngine;

public class ActivateCutScene : MonoBehaviour
{

    [SerializeField] private PlayableDirector playableDirector;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("cut scene activated");
            playableDirector.Play();
            GetComponent<BoxCollider>().enabled = false;
        }
    }
}
