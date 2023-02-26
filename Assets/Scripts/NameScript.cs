using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameScript : MonoBehaviour
{

    public Text nameText;
    public Text scoreText;

    void Start()
    {
	nameText.text = GameManager.userName;   
	scoreText.text = GameManager.score.ToString();       
    }

}
