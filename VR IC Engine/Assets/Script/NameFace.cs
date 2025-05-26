using UnityEngine;

public class NameFace : MonoBehaviour
{
   
    void Update()
    {
        if(Camera.main!=null)
        {
            transform.LookAt(Camera.main.transform.position);
            transform.Rotate(0, 180, 0);
        }
        
    }
}
