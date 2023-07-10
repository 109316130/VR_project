
using UnityEngine;
using UnityEngine.XR.Management;

public class XRInfoMenager : MonoBehaviour
{
    public GameObject xrOrigin;
    public GameObject desktopChareter;

    // Start is called before the first frame update
    void Start()
    {
        var xrSetting = XRGeneralSettings.Instance;

        if(xrSetting == null)
        {
            Debug.Log("XRGeneralSettings is null.");
            return;
        }
        else if(xrSetting.Manager==null)
        {
            Debug.Log("XRMamagerSettings is null.");
            return;
        }
        else if (xrSetting.Manager.activeLoader == null)
        {
            Debug.Log("XRLoader is null.\nOpen Desktop player.");
            xrOrigin.SetActive(false);
            desktopChareter.SetActive(true);
            return;
        }
        else
        {
            Debug.Log("XRLoader is NOT null.");
            xrOrigin.SetActive(true);
            desktopChareter.SetActive(false);
        }
        
    }

    
}
