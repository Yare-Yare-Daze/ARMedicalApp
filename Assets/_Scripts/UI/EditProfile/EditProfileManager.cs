using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditProfileManager : MonoBehaviour
{
    [SerializeField] private EnterProfileName enterProfileName;
    [SerializeField] private ProfileChose profileChose;
    [SerializeField] private GameObject editProfileGO;

    public Action OnEditProfileFinished;

    private void Awake()
    {
        Initialize();
    }

    private void Initialize()
    {
        enterProfileName.OnEnterNameFinished += EnterNameFinishedHandler;
        profileChose.OnProfileChoseFinished += ProfileChoseFinishedHandler;
    }

    private void OnDisable()
    {
        enterProfileName.OnEnterNameFinished -= EnterNameFinishedHandler;
        profileChose.OnProfileChoseFinished -= ProfileChoseFinishedHandler;
    }

    private void EnterNameFinishedHandler()
    {
        enterProfileName.gameObject.SetActive(false);
        profileChose.gameObject.SetActive(true);
    }

    private void ProfileChoseFinishedHandler()
    {
        profileChose.gameObject.SetActive(false);
        editProfileGO.SetActive(false);
    }
}
