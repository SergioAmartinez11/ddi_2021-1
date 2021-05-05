using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButtonScript : MonoBehaviour, IVirtualButtonEventHandler
{
    public Interactable interactableObject;
    private VirtualButtonBehaviour virtualButton;

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        interactableObject.Interact();
        Debug.Log("Se presiono");
    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Se levanto");
    }
    void Awake()
    {
        virtualButton = GetComponent<VirtualButtonBehaviour>();
    }
    // Start is called before the first frame update
    void Start()
    {
        if(virtualButton != null)
        {
            virtualButton.RegisterEventHandler(this);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
