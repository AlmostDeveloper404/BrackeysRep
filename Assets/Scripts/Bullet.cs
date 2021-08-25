using UnityEngine;

public class Bullet : MonoBehaviour
{

    Rigidbody _rigidbody;
    [SerializeField] float bulletSpeed;

    Transform _camera;

    private void Awake()
    {
        _camera = Camera.main.transform;
        _rigidbody = GetComponent<Rigidbody>();
    }
    private void Start()
    {

        _rigidbody.velocity = _camera.forward * bulletSpeed;
    }

    private void Update()
    {
        if (_rigidbody.velocity.magnitude<3f)
        {
            Destroy(gameObject);
        }
    }
}
