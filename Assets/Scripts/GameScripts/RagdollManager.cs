using UnityEngine;
using System.Collections;

public class RagdollManager : MonoBehaviour
{
    public Transform PhizicalTransform;
    public Transform CurrentMeshPosition;
    public Animator AnimatorGO;
    public ConfigurableJoint hips;

    public void Disable()
    {
        PhizicalTransform.gameObject.SetActive(false) ;

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

        StartCoroutine(WaitAfterHitting());
    }

    void Enable()
    {
        PhizicalTransform.gameObject.SetActive(true);

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
        PhizicalTransform.position = CurrentMeshPosition.position;
    }

    IEnumerator WaitAfterHitting()
    {
        yield return new WaitForSeconds(2f);
        Enable();
    }


    //public ConfigurableJoint[] _configurableJoints;

    //public Transform PhizicalTransform;
    //public Transform CurrentMeshPosition;

    //private void Start()
    //{
    //    _configurableJoints = GetComponentsInChildren<ConfigurableJoint>();
    //}

    //public void Disable()
    //{

    //    for (int i = 0; i < _configurableJoints.Length; i++)
    //    {
    //        JointDrive xDrive = _configurableJoints[i].xDrive;
    //        xDrive.positionSpring = 0f;
    //        xDrive.positionDamper = 0f;

    //        _configurableJoints[i].xDrive = xDrive;

    //        JointDrive yDrive = _configurableJoints[i].yDrive;
    //        yDrive.positionSpring = 0f;
    //        yDrive.positionDamper = 0f;

    //        _configurableJoints[i].yDrive = yDrive;

    //        JointDrive zDrive = _configurableJoints[i].zDrive;
    //        zDrive.positionSpring = 0f;
    //        zDrive.positionDamper = 0f;

    //        _configurableJoints[i].zDrive = zDrive;


    //        JointDrive slerpDrive = _configurableJoints[i].slerpDrive;
    //        slerpDrive.positionSpring = 0f;
    //        slerpDrive.positionDamper = 0f;

    //        _configurableJoints[i].slerpDrive = slerpDrive;

    //        StartCoroutine(WaitAfterHitting());
    //    }
    //}

    //public void Enable()
    //{
    //    for (int i = 0; i < _configurableJoints.Length; i++)
    //    {
    //        JointDrive xDrive = _configurableJoints[i].xDrive;
    //        xDrive.positionSpring = 5000000f;
    //        xDrive.positionDamper = 5000f;

    //        _configurableJoints[i].xDrive = xDrive;

    //        JointDrive yDrive = _configurableJoints[i].yDrive;
    //        yDrive.positionSpring = 5000000f;
    //        yDrive.positionDamper = 5000f;

    //        _configurableJoints[i].yDrive = yDrive;

    //        JointDrive zDrive = _configurableJoints[i].zDrive;
    //        zDrive.positionSpring = 5000000f;
    //        zDrive.positionDamper = 5000f;

    //        _configurableJoints[i].zDrive = zDrive;


    //        JointDrive slerpDrive = _configurableJoints[i].slerpDrive;
    //        slerpDrive.positionSpring = 5000000f;
    //        slerpDrive.positionDamper = 5000f;

    //        _configurableJoints[i].slerpDrive = slerpDrive;

    //        PhizicalTransform.position = CurrentMeshPosition.position;
    //    }
    //}


    //IEnumerator WaitAfterHitting()
    //{
    //    yield return new WaitForSeconds(2f);
    //    Enable();
    //}


}
