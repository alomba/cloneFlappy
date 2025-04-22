using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stadistics : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Los puntos son: "+ GameManager.Instance.Points);
        GameManager.Instance.AddPoints(2);
        Debug.Log("Los puntos son: "+ GameManager.Instance.Points);
        GameManager.Instance.AddPoints(10);
        Debug.Log("Los puntos son: "+ GameManager.Instance.Points);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
