using UnityEngine;

public class BulletColision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.GetComponentInParent<RagdollManager>())
        {
            RagdollManager _ragdollManager = collision.collider.GetComponentInParent<RagdollManager>();
            _ragdollManager.Disable();
        }
    }
}
