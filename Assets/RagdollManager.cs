using UnityEngine;

public class RagdollManager : MonoBehaviour
{
    public ConfigurableJoint[] _configurableJoints;

    private void Start()
    {
        _configurableJoints = GetComponentsInChildren<ConfigurableJoint>();
    }

    public void Disable()
    {
        Debug.Log("Yep");

        for (int i = 0; i < _configurableJoints.Length; i++)
        {
            JointDrive xDrive= _configurableJoints[i].xDrive;
            xDrive.positionSpring = 0f;
            xDrive.positionDamper = 0f;

            JointDrive yDrive = _configurableJoints[i].yDrive;
            yDrive.positionSpring = 0f;
            yDrive.positionDamper = 0f;

            JointDrive zDrive = _configurableJoints[i].zDrive;
            zDrive.positionSpring = 0f;
            zDrive.positionDamper = 0f;

            JointDrive slerpDrive = _configurableJoints[i].slerpDrive;
            slerpDrive.positionSpring = 0f;
            slerpDrive.positionDamper = 0f;
        }
    }

    public void Enable()
    {

    }
}
