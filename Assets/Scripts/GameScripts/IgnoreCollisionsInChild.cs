using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreCollisionsInChild : MonoBehaviour {

    public List<Collider> Colliders = new List<Collider>();

    private void Awake() {
        Colliders.Clear();
        GetCollidersFromChild(transform);
        for (int i = 0; i < Colliders.Count; i++) {
            for (int j = 0; j < Colliders.Count; j++) {
                Physics.IgnoreCollision(Colliders[i], Colliders[j]);
            }
        }
    }

    void GetCollidersFromChild(Transform tr) {

        for (int i = 0; i < tr.childCount; i++) {

            if (tr.GetChild(i).GetComponent<Collider>()) {
                Colliders.Add(tr.GetChild(i).GetComponent<Collider>());
                GetCollidersFromChild(tr.GetChild(i));
            }
            
        }

    }

}
