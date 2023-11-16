using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassBreak : MonoBehaviour
{
   public Rigidbody rb;

   public bool isBroken;

   void Start()
   {
        rb.isKinematic = true;
   }

   void Update()
   {
        if (isBroken == true)
        {
            rb.isKinematic = false;
        }
   }

   private void OnTriggerEnter(Collider other)
   {
        if(other.gameObject.tag=="Player")
        {
            isBroken = true;
        }
   }

}
