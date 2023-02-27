using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProfileChose : MonoBehaviour
{
    public Action OnProfileChoseFinished;

    public void OnClickDoctorButton()
    {
        ProfileCurrent.S.InitializeDoctor();
        OnProfileChoseFinished?.Invoke();
    }

    public void OnClickPacientButton()
    {
        ProfileCurrent.S.InitializePacient();
        OnProfileChoseFinished?.Invoke();
    }
}
