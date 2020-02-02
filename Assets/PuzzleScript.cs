using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleScript : MonoBehaviour
{
    private int puzzleType;
    private int puzzleLvl;
    private int pieceCt;

    public Text message;
    public Text timer;
    private float timeLeft;
    private bool playing;

    private RaycastHit2D hit;
    private Touch touch;
    private Touch[] touches;

    private Transform clone;
    public Transform heart1a;
    public Transform heart1b;

    // Start is called before the first frame update
    void Start()
    {
        playing = true;
        timeLeft = 10 + Time.time;

        GetPuzzle();
        SetPuzzle(puzzleType, puzzleLvl, pieceCt);
    }

    // Update is called once per frame
    void Update()
    {
        if (playing)
        {
            GetInput();

            if (pieceCt == 0)
            {
                message.text = "Ya did it";
                playing = false;
            }

            timer.text = Mathf.RoundToInt((timeLeft - Time.time)).ToString("D2");


            if (timeLeft - Time.time <= 0)
            {
                message.text = "womp womp, ya lost";
                playing = false;
            }
        }
    }

    void GetPuzzle()
    {
        puzzleType = 1;
        puzzleLvl = 1;
        pieceCt = 2;
    }

    void GetInput()
    {
        //touch = Input.GetTouch(0);
        //touches = Input.touches;

        //for (int i = 0; i < Input.touchCount; i++)
        if (Input.GetMouseButtonDown(0))
        {
            //Ray ray = Camera.main.ScreenPointToRay(touches[i].position);
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            hit = Physics2D.Raycast(ray.origin, Vector3.forward);
            if (hit.collider != null)
            {
                hit.collider.SendMessage("Move", transform);
            }
        }
        else if (Input.GetMouseButton(0) && hit.collider != null)
        {
        }
        else if (Input.GetMouseButtonUp(0))
        {
            hit.collider.SendMessage("Drop");
        }
    }

    void SetPuzzle(int type, int lvl, int ct)
    {
        Vector3[] pos = new Vector3[ct];
        
        switch(type)
        {
            case 1:
                switch (lvl)
                {
                    case 1:
                        pos = SetPiece(ct);
                        clone = Instantiate(heart1a, pos[0], transform.rotation, transform.parent) as Transform;
                        clone = Instantiate(heart1b, pos[1], transform.rotation, transform.parent) as Transform;
                        clone.parent = this.transform.parent;
                        break;
                    default:
                        break;
                }
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            default:
                break;

        }
    }

   Vector3[] SetPiece(int ct)
    {
        Vector3[] pos = new Vector3[ct];
        int n;

        for(int i = 0; i < ct; i++)
        {
            if (Mathf.Repeat(i+1, 2) > 0)     //if odd
            {
                pos[i].y = -3.2f;
                n = (ct + 1) / 2;
            }
            else
            {
                pos[i].y = 3.2f;
                n = ct / 2;
            }

            switch(n)
            {
                case 1:
                    pos[i].x = 0;
                    break;
                case 2:
                    if (i+1 < 3) pos[i].x = -1.25f;
                    else pos[i].x = 1.25f;
                    break;
                case 3:
                    if (i+1 < 3) pos[i].x = -1.6f;
                    else if (i+1 > 4) pos[i].x = 1.6f;
                    else pos[i].x = 0;
                    break;
                case 4:
                    break;
                default:
                    break;
            }
        }

        return pos;
    }

    void Placed()
    {
        pieceCt--;
    }
}
