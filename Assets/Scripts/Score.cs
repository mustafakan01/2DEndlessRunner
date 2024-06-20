using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Score : MonoBehaviour
{
    public TextMeshProUGUI text;
    private float score;
    
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player")!=null)
        {
            score += 1 * Time.deltaTime;
            text.text = ((int)score).ToString();
        }
    }
}
