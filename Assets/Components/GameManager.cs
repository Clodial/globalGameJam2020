using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
        public int Day { get; set; }
        //decides how recovered or not a stat is
        public int StatHeart { get; set; }
        public int StatEndu { get; set; }
        public int StatStr { get; set; }
        public int StatMind { get; set; }

        //what decides the puzzle and its difficulty
        public int TimeHeart { get; set; }
        public int TimeEndu { get; set; }
        public int TimeStr { get; set; }
        public int TimeMind { get; set; }

        //boolean to tell game to say game over
        public bool GameEnd { get; set; }
        public BodyStats PuzzleMode { get; set; }

        // just a list of activities
        public Dictionary<int, ActivityNode> Activities { get; set; }

    
    void Start()
    {
        this.Day = 0;
        this.StatHeart = 3;
        this.StatEndu = 3;
        this.StatStr = 3;
        this.StatMind = 3;
        this.TimeHeart = 0;
        this.TimeEndu = 0;
        this.TimeStr = 0;
        this.TimeMind = 0;
        this.GameEnd = false;
        this.Activities = new Dictionary<int, ActivityNode>();
        this.PuzzleMode = BodyStats.MIND;
        Activities.Add(0, new ActivityNode("mind and heart", BodyStats.MIND, BodyStats.HEART, ""));
        Activities.Add(1, new ActivityNode("mind and strength", BodyStats.MIND, BodyStats.STRENGTH, ""));
        Activities.Add(2, new ActivityNode("mind and endurance", BodyStats.MIND, BodyStats.ENDURANCE, ""));
        Activities.Add(3, new ActivityNode("heart and mind", BodyStats.HEART, BodyStats.MIND, ""));
        Activities.Add(4, new ActivityNode("heart and strength", BodyStats.HEART, BodyStats.STRENGTH, ""));
        Activities.Add(5, new ActivityNode("heart and endurance", BodyStats.HEART, BodyStats.ENDURANCE, ""));
        Activities.Add(6, new ActivityNode("strength and heart", BodyStats.STRENGTH, BodyStats.HEART, ""));
        Activities.Add(7, new ActivityNode("strength and mind", BodyStats.STRENGTH, BodyStats.MIND, ""));
        Activities.Add(8, new ActivityNode("strength and endurance", BodyStats.STRENGTH, BodyStats.ENDURANCE, ""));
        Activities.Add(9, new ActivityNode("endurance and mind", BodyStats.ENDURANCE, BodyStats.MIND, ""));
        Activities.Add(10, new ActivityNode("endurance and strength", BodyStats.ENDURANCE, BodyStats.STRENGTH, ""));
        Activities.Add(11, new ActivityNode("endurance and heart", BodyStats.ENDURANCE, BodyStats.HEART, ""));
    }

}
