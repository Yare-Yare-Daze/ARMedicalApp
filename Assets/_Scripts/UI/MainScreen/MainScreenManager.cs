using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScreenManager : MonoBehaviour
{
    [SerializeField] private EditProfileManager editProfileManager;
    [SerializeField] private GameObject mainScreenGO;

    private void Awake()
    {
        Initialize();
    }

    private void Initialize()
    {
        editProfileManager.OnEditProfileFinished += EditProfileFinishedHandler;
    }

    private void EditProfileFinishedHandler()
    {
        mainScreenGO.SetActive(true);
    }

}
