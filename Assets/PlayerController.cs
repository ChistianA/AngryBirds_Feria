using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float timer;
    public Text timeCounter;
    // Start is called before the first frame update
    void Start()
    {
        timer = 60f;
    }

    // Update is called once per frame
    private void Update() {
        timer -= Time.deltaTime;
        timeCounter.text = "Time: " + timer.ToString("f0");

    if(timer <= 0){
        SceneManager.LoadScene("Won");
    }
    }
}
