using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class CaptureLogic : MonoBehaviour
{
    [SerializeField]Ragdoll ragdoll;

    public RagdollManager ragdollManager;

    bool isCatched = false;
    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<FirstPersonController>() && ragdollManager.isFall && !isCatched)
        {
            isCatched = true;
            ragdoll = GetComponentInParent<Ragdoll>();
            ragdoll.Death();         
        }
    }

    
}
