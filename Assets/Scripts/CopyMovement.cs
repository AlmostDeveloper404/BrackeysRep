using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyMovement : MonoBehaviour
{
    public ConfigurableJoint ConfigurableJoint;
    public Transform TargetToCopy;

    Quaternion startRotation;

    private void Start()
    {
        startRotation = transform.localRotation;
    }
    private void Update()
    {
        ConfigurableJoint.targetRotation = Quaternion.Inverse(TargetToCopy.localRotation)*startRotation;
    }
}
