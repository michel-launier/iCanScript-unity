using UnityEngine;

namespace iCanScriptExamples.BreakOut {

    public class BricksParticles : MonoBehaviour {

        // =============================================================
        // PUBLIC FUNCTIONS
        // -------------------------------------------------------------

        // -------------------------------------------------------------
        /// Automatically destroy the brick particle after one second.
        public void Start() {
            Destroy(gameObject, 1f);
        }
    }
}
