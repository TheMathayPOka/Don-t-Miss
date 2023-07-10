using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class manager : MonoBehaviour
{
    public float score=0;
    public Text scoretext;

    public void plus(){
        score = score +10;
    }

    void Update(){
        scoretext.text = score.ToString();

        if(Input.GetKey(KeyCode.R)){
            SceneManager.LoadScene("SampleScene");
        }
    }
}
