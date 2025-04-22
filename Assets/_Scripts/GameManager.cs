using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    int points = 0;

    public int Points { get => points; }

    private void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void AddPoints(int value)
    {
        points += value;
    }

    public void MyLoadScene(string nameScene)
    {
        SceneManager.LoadScene(nameScene);
    }
}
