using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SharedLibrary;
using _Scripts;

public class ServerManager : MonoBehaviour
{
    async void Start()
    {
        var profile = await HttpClient.Get<SharedLibrary.Profile>("https://localhost:7137/profile/500");
    }

}
