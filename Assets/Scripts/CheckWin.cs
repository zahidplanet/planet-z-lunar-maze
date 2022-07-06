using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckWin : MonoBehaviour
{
    public GameObject uiMessage;
    public GameObject lightingAnim;

    // Start is called before the first frame update
    void Start()
    {
        uiMessage.SetActive(false);
        lightingAnim.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("MainCamera"))
        {
            //UI appears
            if(!uiMessage.activeInHierarchy)
                uiMessage.SetActive(true);

            //Lighting appears
            if (!lightingAnim.activeInHierarchy)
                lightingAnim.SetActive(true);
        }
    }

}
