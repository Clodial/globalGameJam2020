﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JiggyScript : MonoBehaviour
{
    private bool move;
    private Vector3 startPos;

    private bool set;
    
    // Start is called before the first frame update
    void Start()
    {
        set = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(move)
        {
            transform.position = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x - startPos.x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y - startPos.y, 0);
        }
    }

    void Move()
    {
        if (!set)
        {
            move = true;
            startPos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        }
    }

    void Drop()
    {
        move = false;

        if (transform.position.magnitude < 0.2f)
        {
            transform.position = Vector3.zero;
            set = true;
        }
    }
}