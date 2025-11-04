using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class TriggerActivator : MonoBehaviour
{
    
    public GameObject lensFlare;
    public GameObject audable;// Drag your Lens Flare (SRP) here

   

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("lens"))
        {
            lensFlare.SetActive(true);
            audable.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("lens"))
        {
            lensFlare.SetActive(false);
            audable.SetActive(false);
        }
    }
}
