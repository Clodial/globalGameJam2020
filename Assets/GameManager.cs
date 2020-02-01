using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public struct GameStats
    {
        public int Day { get; set; }
        public int StatHeart { get; set; }
        public int StatEndu { get; set; }
        public int StatStr { get; set; }
        public int StatMind { get; set; }
        public int TimeHeart { get; set; }
        public int TimeEndu { get; set; }
        public int TimeStr { get; set; }
        public int TimeMind { get; set; }
        public bool GameEnd { get; set; }

        public GameStats(int day, int statHeart, int statEndu, int statStr, int statMind, int timeHeart, int timeEndu, int timeStr, int timeMind, bool gameEnd)
        {
            this.Day = day;
            this.StatHeart = statHeart;
            this.StatEndu = statEndu;
            this.StatStr = statStr;
            this.StatMind = statMind;
            this.TimeHeart = timeHeart;
            this.TimeEndu = timeEndu;
            this.TimeStr = timeStr;
            this.TimeMind = timeMind;
            this.GameEnd = gameEnd;
        }

    }

    GameStats mainGame;

    // Start is called before the first frame update
    void Start()
    {
        mainGame = new GameStats();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(mainGame.StatEndu == 0 || mainGame.StatHeart == 0 || mainGame.StatStr == 0 || mainGame.StatMind == 0)
        {
            mainGame.GameEnd = true;
        }
        if (mainGame.GameEnd)
        {
            if(mainGame.StatEndu == 0)
            {
                
            }
            else if(mainGame.StatHeart == 0)
            {

            }
            else if(mainGame.StatStr == 0)
            {

            }
            else
            {

            }
        }
    }
}
