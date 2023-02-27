using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EnterProfileName : MonoBehaviour
{
    [SerializeField] private TMP_InputField inputFieldFirstName;
    [SerializeField] private TMP_InputField inputFieldLastName;
    [SerializeField] private TextMeshProUGUI errorFirstName;
    [SerializeField] private TextMeshProUGUI errorLastName;

    public Action OnEnterNameFinished;

    public void OnClickConfirmButton()
    {
        errorFirstName.gameObject.SetActive(false);
        errorLastName.gameObject.SetActive(false);

        if (inputFieldFirstName.text != "" && inputFieldLastName.text != "")
        {
            ProfileCurrent.S.FirstName = inputFieldFirstName.text;
            ProfileCurrent.S.LastName = inputFieldLastName.text;
            OnEnterNameFinished?.Invoke();
        }
        else 
        {
            if (inputFieldFirstName.text == "")
                errorFirstName.gameObject.SetActive(true);
            if(inputFieldLastName.text == "")
                errorLastName.gameObject.SetActive(true);
            return;
        }
    }
}
