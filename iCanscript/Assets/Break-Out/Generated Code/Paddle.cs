using System;
using UnityEngine;

namespace iCanScriptExamples.BreakOut {

    public class Paddle : MonoBehaviour {
        // =============================================================
        // PUBLIC FIELDS
        // -------------------------------------------------------------
        public float paddleSpeed= 1f;
        public float max= 8f;
        public float min= -8f;
        public string getAxis= "Horizontal";


        // =============================================================
        // PUBLIC FUNCTIONS
        // -------------------------------------------------------------

        // -------------------------------------------------------------
        /// Read the horizontal user input and move the paddle
        /// accordingly.
        /// 
        /// The paddle is clamped to the game area width.
        public void Update() {
            transform.position= new Vector3(Mathf.Clamp((Input.GetAxis(getAxis) * paddleSpeed) + transform.position.x, min, max), -9.5f, 0f);
        }
    }
}
