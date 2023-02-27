using UnityEngine;

public interface IProfileDoctor
{
    public void InitializeDoctor();
}

public interface IProfilePacient
{
    public void InitializePacient();
}

public enum EProfile
{
    None = 0,
    Pacient,
    Doctor
}

public class Profile : MonoBehaviour, IProfileDoctor, IProfilePacient
{
    protected string firstName;
    protected string lastName;
    protected EProfile profileState = EProfile.None;

    public string FirstName
    {
        get { return firstName; }
        set
        {
            if(profileState == EProfile.None)
            {
                firstName = value;
            }
            else
            {
                Debug.Log("FirstName can't be modify after initialize name and profile");
            }
        }
    }

    public string LastName
    {
        get { return lastName; }
        set
        {
            if (profileState == EProfile.None)
            {
                lastName = value;
            }
            else
            {
                Debug.Log("LastName can't be modify after initialize name and profile");
            }
        }
    }

    public EProfile ProfileState
    {
        get { return profileState; }
        set
        {
            if(profileState == EProfile.None)
            {
                profileState = value;
            }
            else
            {
                Debug.Log("ProfileState can't be modify after initialize name and profile");
            }
        }
    }

    public void InitializePacient()
    {
        profileState = EProfile.Pacient;
    }

    public void InitializeDoctor()
    {
        profileState = EProfile.Doctor;
    }
}
