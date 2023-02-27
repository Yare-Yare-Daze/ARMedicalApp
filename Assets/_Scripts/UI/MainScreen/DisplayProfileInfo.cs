using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayProfileInfo : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI displayProfileInfoText;

    private string outputString;

    private void OnEnable()
    {
        outputString = "First name: " + ProfileCurrent.S.FirstName + "\n";
        outputString += "Last name: " + ProfileCurrent.S.LastName + "\n";
        outputString += "You is " + (ProfileCurrent.S.ProfileState == EProfile.Doctor ? "doctor" : "pacient");
        displayProfileInfoText.text = outputString;
    }
}
