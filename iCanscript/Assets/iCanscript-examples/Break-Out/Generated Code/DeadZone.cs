using UnityEngine;

namespace ICanscriptExamples.BreakOut {

    public class DeadZone : MonoBehaviour {
        // =============================================================
        // PRIVATE FIELDS
        // -------------------------------------------------------------


        // =============================================================
        // PUBLIC FUNCTIONS
        // -------------------------------------------------------------

        // -------------------------------------------------------------
        /// Tell Game Manager that the ball has touched the dead zone.
        /// 
        /// The Game Manger will decrease the plyer life and may declare
        /// game over.
        ///
        /// @param colliderInfo Collision information.
        ///
        public void OnTriggerEnter(Collider colliderInfo) {
            Game Manager.LoseLives();
        }

        // -------------------------------------------------------------
        /// Get a copy of the Game Manager.
        public void Start() {
            var theGM= GameObject.Find("GM");
            Game Manager= theGM.GetComponent("GameManager") as ;
        }
    }
}
