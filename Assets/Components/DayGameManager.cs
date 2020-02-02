using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DayGameManager : MonoBehaviour
{

    // this will manage the current day, hold your stats, and 

    public GameObject activityButton1;
    public GameObject activityButton2;
    public GameObject activityButton3;

    private GameManager gameManager;
    int days;

    int hrt;
    int endu;
    int str;
    int mind;

    int situation1;
    int situation2;
    int situation3;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = null;
        GameObject[] gameManagers = GameObject.FindGameObjectsWithTag("GameManager");
        Debug.Log(gameManagers);
        gameManager = gameManagers[0].GetComponent<GameManager>();

        hrt = gameManager.StatHeart;
        endu = gameManager.StatEndu;
        str = gameManager.StatStr;
        mind = gameManager.StatMind;

        situation1 = Random.Range(0, 12);
        situation2 = Random.Range(0, 12);
        while (situation2 == situation1)
        {
            situation2 = Random.Range(0, 12);
        }
        situation3 = Random.Range(0, 12);
        while(situation3 == situation1 || situation3 == situation2)
        {
            situation3 = Random.Range(0, 12);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager != null)
        {
            if (hrt == 0 || endu == 0 || str == 0 || mind == 0)
            {
                gameManager.GameEnd = true;
            }
            if (gameManager.GameEnd)
            {
                if (gameManager.StatEndu == 0)
                {

                }
                else if (gameManager.StatHeart == 0)
                {

                }
                else if (gameManager.StatStr == 0)
                {

                }
                else
                {

                }
            }
        }
    }




}
