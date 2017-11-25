using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceController : MonoBehaviour
{
    public Text _ammoType;
    string textToShow;
    public int _ammoCountEMP;
    public int _ammoCountNoisemaker;
    public int _ammoToAdd;


	// Use this for initialization
	void Start ()
    {
        _ammoCountEMP = 2;
        _ammoCountNoisemaker = 4;
        textToShow = "EMP COUNT - " + _ammoCountEMP.ToString();
    }
	
	// Update is called once per frame
	void Update ()
    {
		if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            textToShow = "EMP COUNT - " + _ammoCountEMP.ToString();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            textToShow = "NOISEMAKER COUNT - " + _ammoCountNoisemaker.ToString();
        }
        _ammoType.text = textToShow;


    }
}
