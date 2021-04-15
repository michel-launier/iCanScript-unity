using UnityEngine;

namespace iCanScriptExamples.RollABall {

    public class MainCamera : MonoBehaviour {
        // =============================================================
        // PUBLIC FIELDS
        // -------------------------------------------------------------
        public Transform player= default(Transform);

        // =============================================================
        // PRIVATE FIELDS
        // -------------------------------------------------------------
        private Vector3 p_offset= default(Vector3);


        // =============================================================
        // PUBLIC FUNCTIONS
        // -------------------------------------------------------------

        public void Start() {
            p_offset= transform.position - player.position;
        }

        public void LateUpdate() {
            transform.position= player.position + p_offset;
        }
    }
}
