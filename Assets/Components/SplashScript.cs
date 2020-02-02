using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScript : MonoBehaviour
{
    private float ct;

    // Start is called before the first frame update
    void Start()
    {
        ct = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
       if(Time.time - ct >= 5)
        {
            SceneManager.LoadScene(1);
        }
    }
}
