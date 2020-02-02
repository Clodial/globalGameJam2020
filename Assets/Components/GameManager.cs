using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
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

    public Dictionary<int, ActivityNode> activities = new Dictionary<int, ActivityNode>();

    public GameManager(int day, int statHeart, int statEndu, int statStr, int statMind, int timeHeart, int timeEndu, int timeStr, int timeMind, bool gameEnd)
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

    // 
    void Start()
    {
        activities.Add(0, new ActivityNode("mind and heart", BodyStats.MIND, BodyStats.HEART, ""));
        activities.Add(1, new ActivityNode("mind and heart", BodyStats.MIND, BodyStats.STRENGTH, ""));
        activities.Add(2, new ActivityNode("mind and heart", BodyStats.MIND, BodyStats.ENDURANCE, ""));
        activities.Add(3, new ActivityNode("mind and heart", BodyStats.HEART, BodyStats.MIND, ""));
        activities.Add(4, new ActivityNode("mind and heart", BodyStats.HEART, BodyStats.STRENGTH, ""));
        activities.Add(5, new ActivityNode("mind and heart", BodyStats.HEART, BodyStats.ENDURANCE, ""));
        activities.Add(6, new ActivityNode("mind and heart", BodyStats.STRENGTH, BodyStats.HEART, ""));
        activities.Add(7, new ActivityNode("mind and heart", BodyStats.STRENGTH, BodyStats.MIND, ""));
        activities.Add(8, new ActivityNode("mind and heart", BodyStats.STRENGTH, BodyStats.ENDURANCE, ""));
        activities.Add(9, new ActivityNode("mind and heart", BodyStats.ENDURANCE, BodyStats.MIND, ""));
        activities.Add(10, new ActivityNode("mind and heart", BodyStats.ENDURANCE, BodyStats.STRENGTH, ""));
        activities.Add(11, new ActivityNode("mind and heart", BodyStats.ENDURANCE, BodyStats.HEART, ""));
    }

}
