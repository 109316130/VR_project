using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HMDInfoMenager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Active device "+XRSettings.isDeviceActive+" "+ XRSettings.loadedDeviceName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
