// using UnityEditor.Build.Content;
// using UnityEngine;
// using UnityEngine.SocialPlatforms.Impl;
//
// public class Goal : MonoBehaviour
// {
//     public int leftScore;
//     public int rightScore;
//
//     public GameObject ball;
//     // Start is called once before the first execution of Update after the MonoBehaviour is created
//     void Start()
//     {
//         leftScore = 0;
//         rightScore = 0;
//     }
//
//     // Update is called once per frame
//     void Update()
//     {
//         
//     }
//
//     void OnCollisionEnter(Collision other)
//     {
//         Destroy(other.gameObject);
//         Score(other.gameObject);
//     }
//
//     void Score(GameObject ball)
//     {
//         if (ball.transform.position.x > 10f)
//         {
//             leftScore++;
//             Debug.Log($"Left Scores! The current score is Left Player: {leftScore}, Right Player: {rightScore}");
//         }
//
//         if (ball.transform.position.x < 10f)
//         {
//             rightScore++;
//         }
//         WinGameCheck(ball);
//     }
//
//     void WinGameCheck(GameObject ball)
//     {
//         if (leftScore == 11)
//         {
//             Debug.Log("Game Over, Left Wins!");
//             leftScore = 0;
//             rightScore = 0;
//             RestartGame();
//         }
//         else if (rightScore == 11)
//         {
//             Debug.Log("Game Over, Right Wins!");
//             leftScore = 0;
//             rightScore = 0;
//             RestartGame();
//         }
//         else
//         {
//             
//             
//         }
//     }
//
//     void RestartGame()
//     {
//         //figure out how to reload the scene from the beginning and what script this goes in
//     }
//     
//     // add a display for the current score
//     
//     
// }
