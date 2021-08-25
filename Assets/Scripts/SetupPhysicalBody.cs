using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetupPhysicalBody : MonoBehaviour {

    public Transform AnimatedBody;

    [ContextMenu("Setup")]
    public void Setup() {
        CopyMovement[] physicalBodyParts = GetComponentsInChildren<CopyMovement>();
        for (int i = 0; i < physicalBodyParts.Length; i++) {
            physicalBodyParts[i].ConfigurableJoint = physicalBodyParts[i].GetComponent<ConfigurableJoint>();

            physicalBodyParts[i].ConfigurableJoint.connectedBody = FindRigidbodyInParent(physicalBodyParts[i].transform.parent);

            Transform target = FindInChild(AnimatedBody, physicalBodyParts[i].name);
            Debug.Log(target);
            physicalBodyParts[i].TargetToCopy = target;
        }
    }

    public Rigidbody FindRigidbodyInParent(Transform tr) {
        Transform t = tr;
        while (t != null) {
            if (t.GetComponent<Rigidbody>()) {
                return t.GetComponent<Rigidbody>();
            } else {
                t = t.parent;
            }
        }
        return null;
    }

    Transform FindInChild(Transform tr, string name) {
        for (int i = 0; i < tr.childCount; i++) {
            if (tr.GetChild(i).name == name) {
                return tr.GetChild(i);
            }
            Transform t = FindInChild(tr.GetChild(i), name);
            if (t != null) {
                return t;
            }
            
        }
        return null;
    }

}
