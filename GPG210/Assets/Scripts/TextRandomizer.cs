using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextRandomizer : MonoBehaviour
{
    public Text textToChange;
    public string[] text;   //Stores an array of strings
    public int randomIndex; //Random index
    public float timer; //Timer, dictating when to change
    public float timerDefault; //Default timer value

	// Use this for initialization
	void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            randomIndex = Random.Range(0, text.Length);
            textToChange.text = text[randomIndex];
            timer = timerDefault;
        }

	}
}
