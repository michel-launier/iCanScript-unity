using System;
using UnityEngine;

namespace iCanScriptExamples.BreakOut {

    public class Ball : MonoBehaviour {
        // =============================================================
        // PUBLIC FIELDS
        // -------------------------------------------------------------
        public bool ballInPlay= false;
        public float ballInitialVelocity= 600f;
        public Transform parent= default(Transform);

        // =============================================================
        // PRIVATE FIELDS
        // -------------------------------------------------------------
        private Rigidbody p_rigidbody= default(Rigidbody);


        // =============================================================
        // PUBLIC FUNCTIONS
        // -------------------------------------------------------------

        // -------------------------------------------------------------
        /// Moves the ball using the physic engine.
        /// 
        /// The ball is given an initial force the first time the user
        /// pressed the fire button then bounces around the
        /// game area.
        public void Update() {
            if(Input.GetButtonDown("Fire1") && (!ballInPlay)) {
                transform.SetParent(parent);
                ballInPlay = true;
                p_rigidbody.isKinematic= false;
                p_rigidbody.AddForce(ballInitialVelocity, ballInitialVelocity, 0f);
            }
        }

        // -------------------------------------------------------------
        /// Get a copy of the rigidbody component of the ball.
        public void Awake() {
            p_rigidbody= GetComponent("Rigidbody") as Rigidbody;
        }
    }
}
