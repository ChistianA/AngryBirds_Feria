using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadManager : MonoBehaviour
{

    public void LoadScene(string i){
        SceneManager.LoadScene(i);
    }
}
