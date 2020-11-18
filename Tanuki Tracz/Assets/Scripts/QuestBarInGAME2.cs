using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestBarInGAME2 : MonoBehaviour
{
    public Slider slider;
    public int currentPoints = 20;
    private int points = 10;
    private int decPoints = 5;
    private int completePoints = 100;
    private float seconds = 0.15f;
    public GameObject isInQuest;
    public GameObject mainCamera;
    public GameObject cameraWatering;
    public float time = 100000.0f;
    public GameObject eButton;
    public GameObject questBar;
    public GameObject motherConversation;
    public QuestsScript quests;


    void Awake()
    {
        SetMinPoints(0);
    }

    private void Update()
    {
        if (isInQuest.GetComponent<JumpToMiniGame3>().questBarActive == true && time > 1000)
        {
            time = 0.0f;
            InvokeRepeating("Points", time, seconds);
            time = 1.0f;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            currentPoints = currentPoints + points;
            SetPoints(currentPoints);

        }

        if (currentPoints == completePoints)
        {
            mainCamera.SetActive(true);
            cameraWatering.SetActive(false);
            eButton.SetActive(false);
            questBar.SetActive(false);
            motherConversation.GetComponent<MotherConversation>().Agreed();
            isInQuest.GetComponent<SphereCollider>().enabled = false;
            quests.quest4SetDesactive();
            quests.quest2SetActive();
            Invoke("ChangeBoolToFalse1", 0.9f);

        }
    }
    void ChangeBoolToFalse1()
    {
        motherConversation.GetComponent<MotherConversation>().isTalking = false;
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


}
