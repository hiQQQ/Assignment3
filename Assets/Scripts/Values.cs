using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Values : MonoBehaviour
{
    public Slider rotatorSpeed;
    public Text rspeedText;

    public Slider pinSpeed;
    public Text pspeedText;

    public InputField uname;

    void Update()
    {
        GameManager.rSpeed = rotatorSpeed.value;
	rspeedText.text = GameManager.rSpeed.ToString();
	GameManager.pSpeed = pinSpeed.value;
	pspeedText.text = GameManager.pSpeed.ToString();
    }

    public void NameUpdate ()
    {
	GameManager.userName = uname.text;
    }

}
