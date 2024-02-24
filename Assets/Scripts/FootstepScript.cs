using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepScript : MonoBehaviour
{
    public GameObject footStep;
    // Start is called before the first frame update
    void Start()
    {
        footStep.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("W"))
        {
            footSteps();
        }
        if (Input.GetKeyDown("A"))
        {
            footSteps();
        }
        if (Input.GetKeyDown("S"))
        {
            footSteps();
        }
        if (Input.GetKeyDown("D"))
        {
            footSteps();
        }
        if (Input.GetKeyUp("W"))
        {
            stopfootSteps();
        }
        if (Input.GetKeyUp("A"))
        {
            stopfootSteps();
        }
        if (Input.GetKeyUp("S"))
        {
            stopfootSteps();
        }
        if (Input.GetKeyUp("D"))
        {
            stopfootSteps();
        }
    }

    void footSteps()
    {
        footStep.SetActive(true);
    }

    void stopfootSteps()
    {
        footStep.SetActive(false);
    }
}
