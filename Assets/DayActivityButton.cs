using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DayActivityButton : MonoBehaviour
{

    private BodyStats MainStress { get; set; }
    private BodyStats SideStress { get; set; }

    private bool CauseStress { get; set; }

    public GameObject dayManager;

    // Start is called before the first frame update
    void Start()
    {
        EventTrigger trigger = GetComponent<EventTrigger>();
        EventTrigger.Entry entry = new EventTrigger.Entry();
        entry.eventID = EventTriggerType.PointerClick;
        entry.callback.AddListener((data) =>
        {
            DealStressToUser(this.MainStress, this.SideStress, this.CauseStress);
        });
        trigger.triggers.Add(entry);
        int extraStress = Random.Range(0, 4);
        if(extraStress == 1)
        {
            CauseStress = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DealStressToUser(BodyStats mainStress, BodyStats sideStress, bool causeStress)
    {
        dayManager.GetComponent<DayGameManager>().ChangeStats(mainStress, sideStress, causeStress);
    }
}
