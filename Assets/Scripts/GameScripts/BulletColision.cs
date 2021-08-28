using UnityEngine;

public class BulletColision : MonoBehaviour
{

    AudioSource audioSource;
    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.GetComponentInParent<RagdollManager>())
        {
            audioSource.Play();
            RagdollManager _ragdollManager = collision.collider.GetComponentInParent<RagdollManager>();
            _ragdollManager.Disable();
        }
        else
        {
            audioSource.Play();
        }
    }
}
