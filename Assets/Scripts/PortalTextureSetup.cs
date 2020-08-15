using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTextureSetup : MonoBehaviour
{

    public Camera cameraB;

    public Material CameraMatB;

    // Start is called before the first frame update
    void Start()
    {
        if(cameraB.targetTexture!=null){
            cameraB.targetTexture.Release();
        }
        cameraB.targetTexture = new RenderTexture(Screen.width, Screen.height, 48);
        CameraMatB.mainTexture= cameraB.targetTexture;
    }


}
