using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleScript : MonoBehaviour
{
    private RaycastHit2D hit;
    private Touch touch;
    private Touch[] touches;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetInput();
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
                hit.collider.SendMessage("Move");
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
}
