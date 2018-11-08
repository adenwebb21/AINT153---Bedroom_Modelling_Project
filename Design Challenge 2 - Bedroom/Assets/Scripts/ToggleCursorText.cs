using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleCursorText : MonoBehaviour
{

    private Text cursorText;
    private string baseText;
    public string objectName;

    private void Start()
    {
        baseText = "Left click to activate ";
        cursorText = GetComponentInChildren<Text>(true);
    }

    public void UpdateText(string hitName)
    {
        VerifyObjectName(hitName);

        if (cursorText.text != cursorText.text + objectName)
        {
            cursorText.text = baseText + objectName;
            cursorText.gameObject.SetActive(true);
        }

    }

    public void TurnTextOff()
    {
        cursorText.gameObject.SetActive(false);
    }

    private string VerifyObjectName(string hitName)
    {
        switch (hitName)
        {
            case "Bolt hardware":
                goto case "Bolt";
            case "Frame side bolt hardware":
                goto case "Bolt";
            case "Bolt handle":
                goto case "Bolt";
            case "Bolt":
                objectName = "bolt";
                break;
            case "Doorbar":
                objectName = "bar";
                break;
            case "Frame side of latch hardware":
                goto case "Latch";
            case "Latchrotation":
                goto case "Latch";
            case "Latch hinge":
                goto case "Latch";
            case "Door side of latch hardware":
                goto case "Latch";
            
            case "Padlock body":
                goto case "Padlock";
            case "Padlock":
                objectName = "padlock";
                break;

            case "Latch":
                objectName = "latch";
                break;
            case "Door":
                objectName = "door";
                break;
        }

        return objectName;
    }
}
