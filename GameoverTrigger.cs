using UnityEngine;
using System.Collections;

public class GameoverTrigger : MonoBehaviour
{
    void OnTriggerEnter()
    {
        PheelGameManager.SP.SetGameOver();
    }
}
