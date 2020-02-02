using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DayGameManager : MonoBehaviour
{

    // this will manage the current day, hold your stats, and 

    public GameObject popupFrame;

    public GameObject activityButton1;
    public GameObject activityButton2;
    public GameObject activityButton3;

    public GameObject activityText1;
    public GameObject activityText2;
    public GameObject activityText3;

    private GameManager gameManager;
    int days;

    int hrt;
    int endu;
    int str;
    int mind;

    int situation1;
    int situation2;
    int situation3;

    bool showPopup;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = null;
        showPopup = false;
        popupFrame.SetActive(false);
        GameObject[] gameManagers = GameObject.FindGameObjectsWithTag("GameManager");
        Debug.Log(gameManagers);
        gameManager = gameManagers[0].GetComponent<GameManager>();

        hrt = gameManager.StatHeart;
        endu = gameManager.StatEndu;
        str = gameManager.StatStr;
        mind = gameManager.StatMind;

        situation1 = Random.Range(0, 12);
        EstablishStresser(situation1, activityButton1, activityText1);
        situation2 = Random.Range(0, 12);
        while (situation2 == situation1)
        {
            situation2 = Random.Range(0, 12);
        }
        EstablishStresser(situation2, activityButton2, activityText2);
        situation3 = Random.Range(0, 12);
        while(situation3 == situation1 || situation3 == situation2)
        {
            situation3 = Random.Range(0, 12);
        }
        EstablishStresser(situation3, activityButton3, activityText3);
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

    public void ChangeStats(BodyStats mainStress, BodyStats sideStress, bool addStress) 
    {
        popupFrame.SetActive(true);
        CalculateStress(mainStress);
        if (addStress)
        {
            CalculateStress(sideStress);
        }
    }

    private void CalculateStress(BodyStats stresser)
    {
        switch (stresser)
        {
            case (BodyStats.HEART):
                hrt--;
                break;
            case (BodyStats.MIND):
                mind--;
                break;
            case (BodyStats.STRENGTH):
                str--;
                break;
            default:
                endu--;
                break;
        }
    }

    private void EstablishStresser(int stressIndex, GameObject activity, GameObject activityText)
    {
        ActivityNode node = gameManager.Activities[stressIndex];
        activity.GetComponent<DayActivityButton>().MainStress = node.MainStress;
        activity.GetComponent<DayActivityButton>().SideStress = node.SideStress;
        activityText.GetComponent<Text>().text = node.FlavorText;
    }
}
