using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform Bullet;
    public Transform FirePoint;

    AudioSource source;

    float reloading = .3f;
    float timer;


    private void Awake()
    {
        source = GetComponent<AudioSource>();
    }
    private void Update()
    {
        timer = Mathf.Clamp(timer,-1f,Mathf.Infinity);
        timer -= Time.deltaTime;
        if (Input.GetMouseButtonDown(0) && timer<=0)
        {
            Shoot();
            timer = reloading;
        }
    }

    void Shoot()
    {
        Transform bulletGO= Instantiate(Bullet,FirePoint.position,transform.rotation);
        source.Play();
    }
}
