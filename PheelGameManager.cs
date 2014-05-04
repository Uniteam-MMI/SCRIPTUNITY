using UnityEngine;
using System.Collections;
public enum PheelGameState {playing, won,lost };

public class PheelGameManager : MonoBehaviour
{
    public static PheelGameManager SP;

    private int totalFeelings;
    private int foundFeelings;
    private PheelGameState gameState;


    void Awake()   // au chargement du jeu
    {
        SP = this; 
        foundFeelings = 0;
        gameState = PheelGameState.playing;
        totalFeelings = GameObject.FindGameObjectsWithTag("Feeling").Length;
        Time.timeScale = 1.0f;

    }

	void OnGUI () {
	    GUILayout.Label(" Feelings found: "+foundFeelings+"/"+totalFeelings );

        if (gameState == PheelGameState.lost)
        {
            GUILayout.Label("You Lost!");
            if(GUILayout.Button("Try again") ){
                Application.LoadLevel(Application.loadedLevel);
            }
        }
        else if (gameState == PheelGameState.won)
        {
            GUILayout.Label("You won!");
            if(GUILayout.Button("Play again") ){
                Application.LoadLevel(Application.loadedLevel);
            }
        }
	}

    public void FoundFeeling() //compteur
    {
        foundFeelings++;
		if (foundFeelings >= totalFeelings)
        {
           //Faire apparaitre le trésor
        }
    }

    public void WonGame()
    {
        Time.timeScale = 0.0f; //Pause game
        gameState = PheelGameState.won;
    }

    public void SetGameOver()
    {
        Time.timeScale = 0.0f; //Pause game
        gameState = PheelGameState.lost;
    }
}
