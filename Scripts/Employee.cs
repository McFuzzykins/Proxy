using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Employee : MonoBehaviour
{
    public string UsernameD = "BingBong";
    public string PasswordD = "FYL!24";

    public string Username;
    public string Password;
    public string Role;

    public Employee(string username, string password)
    {
        Debug.Log(username + " Employee");
        Debug.Log(password + " Employee");

        if(username == UsernameD && password == PasswordD)
        {
            Role = "Developer";
        }
        else
        {
            Role = "Intern";
        }
    }
}
