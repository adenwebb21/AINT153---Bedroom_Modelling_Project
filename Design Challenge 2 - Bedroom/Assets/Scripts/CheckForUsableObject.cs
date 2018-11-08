using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForUsableObject : MonoBehaviour
{

    private Camera cam;
    private Transform camTransform;

    public AnimationManager manager;
    public Crosshair crosshairScript;

    private void Start()
    {
        cam = GetComponentInChildren<Camera>();
        camTransform = GetComponentInChildren<Transform>();
    }

    void Update()
    {
        Ray ray = cam.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 1f))
        {
            if (hit.transform.tag == "UsableObject") 
            {
                crosshairScript.LookingAtUsableObject();
            }
            else
            {
                crosshairScript.NotLookingAtUsableObject();
            }

            if (Input.GetButtonDown("Fire1"))
            {
                manager.TriggerAnimation(hit.collider.name);
            }
        }
        else
        {
            crosshairScript.NotLookingAtUsableObject();
        }

    }
}
