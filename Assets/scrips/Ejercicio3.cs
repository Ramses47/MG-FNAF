using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3 : MonoBehaviour
{
    public GameObject myLight;
    private bool isOn;

    // Start is called before the first frame update
    void Start()
    {
        isOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        SwitchLight();
    }

    void SwitchLight()
    {
        if (Input.GetKeyUp(KeyCode.F))
        {
            if (isOn)
            {
                myLight.GetComponent<Light>().enabled = false;
                isOn = false;
            }
            else
            {
                myLight.GetComponent<Light>().enabled = true;
                isOn = true;
            }
            
        }
    }
}
