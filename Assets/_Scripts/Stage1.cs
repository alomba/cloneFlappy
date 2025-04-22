using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Stage1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("El valor de points después de cargar la escena es: " + GameManager.Instance.Points);
        GameManager.Instance.AddPoints(50);
        Debug.Log("El valor de points después de actualiar valores es: " + GameManager.Instance.Points);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
