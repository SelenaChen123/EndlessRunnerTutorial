using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelDistance : MonoBehaviour
{
    public GameObject distanceDisplay;
    public int distanceRun;
    public bool addingDistance = false;
    public float distanceDelay = 0.5f;

    // Update is called once per frame
    void Update()
    {
        if (addingDistance == false)
        {
            addingDistance = true;
            StartCoroutine(AddingDistance());
        }
    }

    IEnumerator AddingDistance()
    {
        distanceRun += 1;
        distanceDisplay.GetComponent<Text>().text = "" + distanceRun;
        yield return new WaitForSeconds(distanceDelay);
        addingDistance = false;
    }
}
