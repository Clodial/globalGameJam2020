using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class PopupButton : MonoBehaviour
{

    GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        GameObject[] gameManagers = GameObject.FindGameObjectsWithTag("GameManager");
        gameManager = gameManagers[0].GetComponent<GameManager>();

        EventTrigger trigger = GetComponent<EventTrigger>();
        EventTrigger.Entry entry = new EventTrigger.Entry();
        entry.eventID = EventTriggerType.PointerClick;
        entry.callback.AddListener((data) =>
        {
            if (gameManager.GameEnd)
            {
                SceneManager.LoadScene(0);
            }
            else{
                SceneManager.LoadScene(4);
            }
        });
        trigger.triggers.Add(entry);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
