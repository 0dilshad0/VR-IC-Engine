using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class Screwdriver : MonoBehaviour
{
    private XRGrabInteractable interactable;
    private bool IsPick=false;

    public Animator animator;
    public GameObject Marker;
    private void Awake()
    {
        interactable = GetComponent<XRGrabInteractable>();

        interactable.selectEntered.AddListener(Grab);
        interactable.selectExited.AddListener(Remove);
    }

    private void Update()
    {
        if(IsPick && Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("Remove");
        }
    }

    public void Grab(SelectEnterEventArgs args)
    {
        Marker.SetActive(false);
        IsPick = true;
    }
    public void Remove(SelectExitEventArgs args)
    {
        IsPick = false;
    }

}
