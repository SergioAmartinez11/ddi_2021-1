using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColor : MonoBehaviour
{
    public void Green()
    {
        GetComponent<Renderer>().material.color = Color.green;
    }
    public void White()
    {
        GetComponent<Renderer>().material.color = Color.white;
    }
    public void Red()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }
}
