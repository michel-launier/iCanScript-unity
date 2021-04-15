using UnityEngine;

namespace iCanScriptExamples.RollABall {

    public class Rotator : MonoBehaviour {

        // =============================================================
        // PUBLIC FUNCTIONS
        // -------------------------------------------------------------

        public void Update() {
            transform.Rotate(new Vector3(15f, 30f, 45f) * Time.deltaTime);
        }
    }
}
