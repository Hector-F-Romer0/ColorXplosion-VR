using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ActivadorCubo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
        // grabbable.activated.AddListener(lanzarInteracion);
        grabbable.hoverEntered.AddListener(lanzarInteracion);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void lanzarInteracion(HoverEnterEventArgs args)
    {

        Debug.Log("Presionó/Agarró.");
    }
}
