using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetCube : MonoBehaviour
{
    // Start is called before the first frame update
    private Renderer cubo;
    private string speachColor;
    void Start()
    {
        cubo = GetComponent<Renderer>();

        cubo.material.SetColor("_Color",Color.black);
    }

    // Update is called once per frame
    void Update()
    {
        if(speachColor == "azul"){
             cubo.material.SetColor("_Color",Color.blue);
        }
        if(speachColor == "verde"){
             cubo.material.SetColor("_Color",Color.green);
        }
        if(speachColor == "rojo"){
             cubo.material.SetColor("_Color",Color.red);
        }
        else{
             cubo.material.SetColor("_Color",Color.black);
        }
        
    }
    public void ReadStringInput(string s){
        speachColor = s;
    }
}
