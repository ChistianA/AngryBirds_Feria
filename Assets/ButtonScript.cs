using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ButtonScript : MonoBehaviour
{
    public Image fillImage;
    public UnityEvent VRClick;
    public float totalTime = 2;
    bool status;
    public float Timer;

    // Update is called once per frame
    void Update()
    {
        if(status){
            Timer += Time.deltaTime;
            fillImage.fillAmount = Timer / totalTime;
        }
        if(Timer > totalTime){
            VRClick.Invoke();
        }
    }

    public void VROn(){
        status = true;
    }

    public void VROff(){
        status = false;
        Timer = 0;
        fillImage.fillAmount = 0;

    }
}
