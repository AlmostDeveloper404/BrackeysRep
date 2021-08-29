using UnityEngine;
using System.Collections;
using UnityEngine.AI;



public class RagdollManager : MonoBehaviour
{
    public Transform PhizicalTransform;
    public Transform CurrentMeshPosition;
    public Animator AnimatorGO;
    public ConfigurableJoint hips;
    public NavMeshAgent agent;

    AudioSource audioSource;

    Material startMaterial;
    public Material DisableMat;

    public SkinnedMeshRenderer _meshRenderer;

    public bool isFall;

    float timeToGetUp=3f;
    float timePassed;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }


    private void Start()
    {
        startMaterial = _meshRenderer.material;
    }

    [ContextMenu("Disable")]
    public void Disable()
    {
        audioSource.Play();

        isFall = true;

        timePassed = timeToGetUp;

        _meshRenderer.material = DisableMat;

        agent.enabled = false;
        JointDrive xDrive = hips.xDrive;
        xDrive.positionSpring = 0f;
        xDrive.positionDamper = 0f;

        hips.xDrive = xDrive;

        JointDrive yDrive = hips.yDrive;
        yDrive.positionSpring = 0f;
        yDrive.positionDamper = 0f;

        hips.yDrive = yDrive;

        JointDrive zDrive = hips.zDrive;
        zDrive.positionSpring = 0f;
        zDrive.positionDamper = 0f;

        hips.zDrive = zDrive;


        JointDrive slerpDrive = hips.slerpDrive;
        slerpDrive.positionSpring = 0f;
        slerpDrive.positionDamper = 0f;

        hips.slerpDrive = slerpDrive;

        AnimatorGO.enabled = false;
    }

    void Enable()
    {
        isFall = false;

        _meshRenderer.material = startMaterial;

        agent.enabled = true;

        JointDrive xDrive = hips.xDrive;
        xDrive.positionSpring = 5000000f;
        xDrive.positionDamper = 5000f;

        hips.xDrive = xDrive;

        JointDrive yDrive = hips.yDrive;
        yDrive.positionSpring = 5000000f;
        yDrive.positionDamper = 5000f;

        hips.yDrive = yDrive;

        JointDrive zDrive = hips.zDrive;
        zDrive.positionSpring = 5000000f;
        zDrive.positionDamper = 5000f;

        hips.zDrive = zDrive;


        JointDrive slerpDrive = hips.slerpDrive;
        slerpDrive.positionSpring = 5000000f;
        slerpDrive.positionDamper = 5000f;



        hips.slerpDrive = slerpDrive;
        AnimatorGO.enabled = true;    
    }

    private void Update()
    {
        if (hips.transform.position.y<-1.5f)
        {
            GetComponentInParent<Ragdoll>().Death();
        }
        if (isFall)
        {
            timePassed= Mathf.Clamp(timePassed,-1f,Mathf.Infinity);
            timePassed -= Time.deltaTime;
            if (timePassed  <=0f)
            {
                Enable();
            }

            NavMeshHit hit;
            if (NavMesh.SamplePosition(hips.transform.position, out hit, 500f, NavMesh.AllAreas))
            {
                Debug.DrawRay(hit.position, Vector3.up);
                PhizicalTransform.position = hit.position;
            }
        }
    }
}
