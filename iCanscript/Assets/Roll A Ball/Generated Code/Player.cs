using System;
using UnityEngine;
using UnityEngine.UI;

namespace iCanScriptExamples.RollABall {

    public class Player : MonoBehaviour {
        // =============================================================
        // PUBLIC FIELDS
        // -------------------------------------------------------------
        public int count= 0;
        public float speed= 10f;
        public Text countText= default(Text);
        public Text youWinText= default(Text);

        // =============================================================
        // PRIVATE FIELDS
        // -------------------------------------------------------------
        private Rigidbody p_rigidbody= default(Rigidbody);


        // =============================================================
        // PUBLIC FUNCTIONS
        // -------------------------------------------------------------

        // -------------------------------------------------------------
        /// Computes the new position of the ball on the physic
        /// update tick.
        public void FixedUpdate() {
            p_rigidbody.AddForce(speed * new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")));
        }

        // -------------------------------------------------------------
        /// Find the reference to our rigidbody for later use
        /// and displays the initial number of collected objects.
        public void Start() {
            p_rigidbody= gameObject.GetComponent("Rigidbody") as Rigidbody;
            SetCount();
        }

        // -------------------------------------------------------------
        /// This function is called when a collision is detected.  We first
        /// verify if the object with whom we collided was 'pickup' object
        /// and if so we remove it and increment the count of
        /// collected objects.
        ///
        /// @param colliderInfo Provides a description of the object in
        ///                     collision.
        ///
        public void OnTriggerEnter(Collider colliderInfo) {
            var theCollider= colliderInfo.gameObject;
            theCollider.SetActive(false);
            if(theCollider.CompareTag("pickup")) {
                ++count;
                SetCount();
            }
        }

        // -------------------------------------------------------------
        /// Displays the number of object collected thus far and
        /// verifies for end of game condition.
        public void SetCount() {
            countText.text= "Score: " + count;
            if(count >= 12) {
                youWinText.text= "You Won!";
            }
        }
    }
}
