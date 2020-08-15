using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalCamera : MonoBehaviour
{
    public Transform playerCamera;
    public Transform portal;
    public Transform otherPortal1;

    // Update is called once per frame
    void Update()
    {
        Vector3 playerOffsetFromPortal = playerCamera.position - otherPortal1.position;
        transform.position = portal.position + playerOffsetFromPortal;


        float angularDifferenceBetweenPortalRotations= Quaternion.Angle(portal.rotation, otherPortal1.rotation);
        Quaternion portalRotationaldifference = Quaternion.AngleAxis(angularDifferenceBetweenPortalRotations,Vector3.up);
        Vector3 newCameraDirection = portalRotationaldifference * playerCamera.forward;
        transform.rotation = Quaternion.LookRotation(newCameraDirection,Vector3.up);
    }
}
