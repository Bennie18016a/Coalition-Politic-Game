using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Reputation : MonoBehaviour
{
    [Header("Fundermentals")]
    [Tooltip("The slider which shows the reputation")]
    public Slider repSlider;
    [Tooltip("Text that shows exact reputation")]
    public TMP_Text repText;
    [Tooltip("The maximum amount of rep you can have")]
    [Range(0, 100)]
    public int maxRep;

    [Header("Variables")]
    [Tooltip("The reputation the group has towards you")]
    public int _reputation;
    [Tooltip("Amount of money they give to you every in-game hour")]
    public int toGive;

    private void Start()
    {
        //Sets the sliders max value to the maxrep value
        repSlider.maxValue = maxRep;
        //Sets the starting value to be random
        _reputation = Random.Range(49, 100) + 1;
    }

    private void Update()
    {
        //Sets slider value to reputation
        repSlider.value = _reputation;
        //Sets the text how much reputation they have
        repText.text = _reputation.ToString();
        //Sets the amount they give you to their reputation multiplied by 100
        toGive = _reputation * 100;

        //If reputation is above the maxmimum
        if (_reputation > maxRep)
        {
            //Set it to the maximum
            _reputation = maxRep;
            //Else its below 0
        }
        else if (_reputation < 0)
        {
            //Sets it to 0
            _reputation = 0;
        }
    }

    public void ReputationManager(int addition)
    {
        //Increases and decreases the reputation when needed
        _reputation += addition;
    }
}
