using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuestBar : MonoBehaviour
{
    public Slider slider;
    public int currentPoints = 20;
    private int points = 10;
    private int decPoints = 5;
    private int completePoints = 100;
    private float seconds = 0.15f;
    void Start()
    {
        SetMinPoints(0);
        StartCoroutine(decreasePoints());
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)){
            currentPoints = currentPoints + points;
            SetPoints(currentPoints); 
          
        }
        if (currentPoints == completePoints)
        {
            GameManager.instance.washingComplete = true;
            SceneManager.LoadScene("TestScripts");
        }
    }

    void Points()
    {
        currentPoints = currentPoints - decPoints;
        SetPoints(currentPoints);
    }

    public void SetMinPoints(int points)
    {
        slider.minValue = points;
        slider.value = 20;
    }

    public void SetPoints(int points)
    {
        slider.value = points;
    }

    IEnumerator decreasePoints()
    {
        while (true)
        {
            yield return new WaitForSeconds(seconds);
            Points();
        }
    }

}
