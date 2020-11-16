using UnityEngine;
using System.Collections;
using System;
using UnityEngine.SceneManagement;
//using System.Runtime.Serialization.Formatters.Binary;
//using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class GameManager : MonoBehaviour
{
    public GameObject tanuki;
    public Vector3 position;
    public bool washingComplete = false;

    public static GameManager instance = null;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            //PlayerPrefs.DeleteAll();
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);

    }

    void Start() { }
    void Update() { }

    public void SavePosition()
    {
        position = tanuki.transform.position;
    }
}
