using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagdollCapture : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ragdoll"))
        {
            Debug.Log("Yep");
        }
        
    }
    
}
