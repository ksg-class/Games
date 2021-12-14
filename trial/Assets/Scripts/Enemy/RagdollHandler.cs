using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


namespace Alpha
{
    public class RagdollHandler : MonoBehaviour
    {
        #region Variables
        private Collider mainCollider;
        private Collider triggerCollider;
        private Rigidbody mainRigidbody;
        private List<Rigidbody> ragdollRigidbody;
        private List<Collider> ragdollColliders;
        private Animator animator;
        #endregion

        #region Builtin Methods
        private void Awake()
        {
            Initalize();
            AllRigidbodysAndColliders(true);
        }
        #endregion

        #region Custom Methods
        void Initalize()
        {
            mainCollider = GetComponent<CapsuleCollider>();
            triggerCollider = GetComponent<SphereCollider>();
            mainRigidbody = GetComponent<Rigidbody>();

            ragdollRigidbody = new List<Rigidbody>();
            ragdollColliders = new List<Collider>();

            ragdollRigidbody=GetComponentsInChildren<Rigidbody>().ToList<Rigidbody>();
            ragdollColliders = GetComponentsInChildren<Collider>().ToList<Collider>();

            if (mainRigidbody)
            {
                if (ragdollRigidbody.Count > 0)
                {
                    ragdollRigidbody.Remove(mainRigidbody);
                }
            }

            if (ragdollColliders.Count > 0)
            {
                if (mainCollider)
                {
                    ragdollColliders.Remove(mainCollider);
                }

                if(triggerCollider)
                {
                    ragdollColliders.Remove(triggerCollider);

                }
            }

            animator = GetComponentInChildren<Animator>();
        }

        public void EnableRagdoll()
        {
            animator.enabled = false;
            mainCollider.enabled = false;

            AllRigidbodysAndColliders(false);

            
        }

        void AllRigidbodysAndColliders(bool enable)
        {
            if (ragdollRigidbody.Count > 0)
            {
                foreach (Rigidbody rb in ragdollRigidbody)
                {
                    rb.useGravity = !enable;
                    rb.isKinematic = enable;

                }

                foreach (Collider collider in ragdollColliders)
                {
                    collider.enabled = !enable;

                }
            }
        }
        #endregion

    }
}
