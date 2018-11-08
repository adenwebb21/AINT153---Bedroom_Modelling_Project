using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosshair : MonoBehaviour
{
    private Texture2D crosshair;
    private Texture2D currentCrosshair;
    private Rect position;

    public Texture2D alternateCrosshair;

    private void Start()
    {
        crosshair = Texture2D.whiteTexture;
        alternateCrosshair = Texture2D.blackTexture;
        currentCrosshair = crosshair;
    }

    // Update is called once per frame
    void Update()
    {
        position = new Rect((Screen.width - currentCrosshair.width) / 2, (Screen.height - currentCrosshair.height) / 2, currentCrosshair.width, currentCrosshair.height);
    }

    void OnGUI()
    {
        GUI.DrawTexture(position, currentCrosshair);
    }

    public void LookingAtUsableObject()
    {
        currentCrosshair = alternateCrosshair;
    }

    public void NotLookingAtUsableObject()
    {
        currentCrosshair = crosshair;
    }
}
