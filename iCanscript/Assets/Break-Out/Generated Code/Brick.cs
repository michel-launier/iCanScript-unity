using UnityEngine;

namespace iCanScriptExamples.BreakOut {

    public class Brick : MonoBehaviour {
        // =============================================================
        // PUBLIC FIELDS
        // -------------------------------------------------------------
        public Object bricksParticles= default(Object);

        // =============================================================
        // PRIVATE FIELDS
        // -------------------------------------------------------------
        private GameManager p_gameManager= default(GameManager);


        // =============================================================
        // PUBLIC FUNCTIONS
        // -------------------------------------------------------------

        // -------------------------------------------------------------
        /// Performs the following actions when the ball collides with
        /// the brick:
        /// 
        /// 1) Instantiate the brick particles;
        /// 2) Tell the Game manger that one les brick exists;
        /// 3) Destroy the brick.
        ///
        /// @param collisionInfo The collision information.
        ///
        public void OnCollisionEnter(Collision collisionInfo) {
            Instantiate(bricksParticles, transform.position, Quaternion.identity);
            Destroy(gameObject);
            p_gameManager.DestroyBricks();
        }

        // -------------------------------------------------------------
        /// Get a copy of the Game Manager.
        public void Start() {
            var theGM= GameObject.Find("GM");
            p_gameManager= theGM.GetComponent("GameManager") as GameManager;
        }
    }
}
