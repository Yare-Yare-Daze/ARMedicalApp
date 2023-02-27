using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProfileCurrent : Profile
{
    static public ProfileCurrent S;

    private void Awake()
    {
        S = this;
    }
}
