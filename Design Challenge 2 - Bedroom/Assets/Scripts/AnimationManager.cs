using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour {

    public Animator drawer;
    public AudioSource source;

    private bool drawerOpen = false;

    public void TriggerAnimation(string name)
    {
        switch(name)
        {
            case "drawer":
                if(drawerOpen)
                {
                    drawer.SetTrigger("drawerclosed");
                    source.PlayDelayed(0.5f);
                    drawerOpen = false;
                }               
                else
                {
                    drawer.SetTrigger("draweropen");
                    source.PlayDelayed(0.5f);
                    drawerOpen = true;
                }
                break;
        }

    }
}
