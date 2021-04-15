using UnityEngine;

namespace iCanScriptExamples.BreakOut {

    public class DeadZone : MonoBehaviour {
        // =============================================================
        // PRIVATE FIELDS
        // -------------------------------------------------------------
        private GameManager p_gameManager= default(GameManager);


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
            p_gameManager.LoseLives();
        }

        // -------------------------------------------------------------
        /// Get a copy of the Game Manager.
        public void Start() {
            var theGM= GameObject.Find("GM");
            p_gameManager= theGM.GetComponent("GameManager") as GameManager;
        }
    }
}
