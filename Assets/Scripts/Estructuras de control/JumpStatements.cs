using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cours.EstructurasDeControl
{
    public struct PlayerData
    {
        public int score;
        public bool isAlive;
    }
    public class JumpStatements : MonoBehaviour
    {
        public PlayerData[] playerData;

        //Puntaje maximo general
        private void CheckMaxScore()
        {
            for(int i = 0; i < playerData.Length; i++)
            {
                // If score >= 10, win
                if (playerData[i].score >= 10)
                {
                    // Winner
                    break;
                }
            }
        }

        //Puntaje maximo por jugador
        private void CheckPlayerScore()
        {
            for (int i = 0;i < playerData.Length; i++)
            {
                // If isn't alive, skip
                if (!playerData[i].isAlive)
                {
                    continue;
                }
                // Other logic
            }
        }

        private void CheckPlayerScore(int index)
        {
            // If isn't alive, don't execute
            if (!playerData[index].isAlive)
            {
                return; // Early exit
            }
            // Other Logic
        }
    }
}
