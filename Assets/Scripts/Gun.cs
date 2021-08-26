using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform Bullet;
    public Transform FirePoint;

    AudioSource source;


    private void Awake()
    {
        source = GetComponent<AudioSource>();
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Transform bulletGO= Instantiate(Bullet,FirePoint.position,transform.rotation);
        source.Play();
    }
}
