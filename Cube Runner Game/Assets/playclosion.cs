using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playclosion : MonoBehaviour
    
{
        public playerMovement movement;
    void OnCollisionEnter (Collision info) {
       if (info.collider.tag == "hti") {
            movement.enabled = false;
       }
    }


}
