using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{

    private GameManager gameManager;
    public BodyStats chosenStat { get; set; }
    public int levelDifficulty { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        GameObject[] gameManagers = GameObject.FindGameObjectsWithTag("GameManager");
        gameManager = gameManagers[0].GetComponent<GameManager>();

        chosenStat = gameManager.PuzzleMode;
        Debug.Log(chosenStat);
        levelDifficulty = SetDifficulty(chosenStat, gameManager);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int SetDifficulty(BodyStats chosenStats, GameManager gameManager)
    {
        switch (chosenStats)
        {
            case BodyStats.ENDURANCE:
                return gameManager.TimeEndu;
            case BodyStats.HEART:
                return gameManager.TimeHeart;
            case BodyStats.MIND:
                return gameManager.TimeMind;
            default:
                return gameManager.TimeStr;
        }
    }
}
