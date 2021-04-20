using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace ICanscriptExamples.BreakOut {

    public class GameManager : MonoBehaviour {
        // =============================================================
        // PUBLIC FIELDS
        // -------------------------------------------------------------
        public int lives= 3;
        public int bricks= 20;
        public Text livesText= default(Text);
        public GameObject gameOverText= default(GameObject);
        public GameObject youWonText= default(GameObject);
        public UnityEngine.Object bricksPrefab= default(UnityEngine.Object);
        public UnityEngine.Object deathParticles= default(UnityEngine.Object);
        public UnityEngine.Object paddlePrefab= default(UnityEngine.Object);

        // =============================================================
        // PRIVATE FIELDS
        // -------------------------------------------------------------
        private GameObject p_clonePaddle= default(GameObject);


        // =============================================================
        // PUBLIC FUNCTIONS
        // -------------------------------------------------------------

        // -------------------------------------------------------------
        /// Initialize the scene on script wakeup.
        public void Awake() {
            SetUp();
        }

        // -------------------------------------------------------------
        /// Setup the initial position of the paddle and bircks.
        public void SetUp() {
            SetuPaddle();
            Instantiate(bricksPrefab, transform.position, Quaternion.identity);
        }

        // -------------------------------------------------------------
        /// Performs a countdown of the number of bricks and
        /// verifies the game over conditions.
        public void DestroyBricks() {
            --bricks;
            CheckGameOver();
        }

        // -------------------------------------------------------------
        /// The player loses one life and the game over conditions are
        /// verified.
        public void LoseLives() {
            livesText.text= "Lives : " + (--lives);
            Instantiate(deathParticles, p_clonePaddle.transform.position, Quaternion.identity);
            Destroy(p_clonePaddle);
            Invoke("SetuPaddle", 1f);
            CheckGameOver();
        }

        // -------------------------------------------------------------
        /// Compares the number of lives and the number of remaining
        /// bricks to determine if a game over conditions have occured.
        /// 
        /// The player wins if no bricks remain and loses if he/she has
        /// no lives left.
        public void CheckGameOver() {
            if(bricks < 1) {
                youWonText.SetActive(true);
                Time.timeScale= 0.25f;
                Invoke("Reset", 1f);
            }
            if(lives < 1) {
                gameOverText.SetActive(true);
                Time.timeScale= 0.25f;
                Invoke("Reset", 1f);
            }
        }

        // -------------------------------------------------------------
        /// Reloads the level after a game over has been declared.
        public void Reset() {
            Time.timeScale= 1f;
            var theGetActiveScene= SceneManager.GetActiveScene();
            SceneManager.LoadScene(theGetActiveScene.buildIndex);
        }

        // -------------------------------------------------------------
        /// Initializes the position of the paddle and the ball.
        public void SetuPaddle() {
            p_clonePaddle= Instantiate(paddlePrefab, transform.position, Quaternion.identity) as GameObject;
        }
    }
}
