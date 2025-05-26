using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class TogleKinemetic : MonoBehaviour
{
    private Rigidbody rb;
    private XRGrabInteractable interactable;
    public GameObject Name;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true; 
        interactable = GetComponent<XRGrabInteractable>();
        if (Name != null)
        {
            Name.SetActive(false);
        }

        interactable.selectEntered.AddListener(OnGrab);
        interactable.selectExited.AddListener(OnReleas);
       
    }
    
    private void OnGrab(SelectEnterEventArgs args)
    {
        if (Name!=null)
        {
            Name.SetActive(true);
        }
     
    }
    private void OnReleas(SelectExitEventArgs args)
    {
        rb.isKinematic = false;
        if (Name != null)
        {
            Name.SetActive(false);
        }
    }
}
