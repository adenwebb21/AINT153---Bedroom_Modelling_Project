using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour {

    public Animator drawer;

    private bool drawerOpen = false;

    public void TriggerAnimation(string name)
    {
        switch(name)
        {
            case "drawer":
                if(drawerOpen)
                {
                    drawer.SetTrigger("drawerclosed");
                    drawerOpen = false;
                }               
                else
                {
                    drawer.SetTrigger("draweropen");
                    drawerOpen = true;
                }
                break;
        }

    }
}
