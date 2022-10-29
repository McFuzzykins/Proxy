using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Client : MonoBehaviour
{
    [Header("Stuff")]
    public Button login;
    public TMP_Text info;
    public TMP_InputField user;
    public TMP_InputField pass;

    public void OnUserChanged(TMP_InputField u)
    {
        user = u;
        Debug.Log(user.text + " OnUserChanged");
    }

    public void OnPassChanged(TMP_InputField p)
    {
        pass = p;
        Debug.Log(pass.text + " OnPassChanged");
    }

    public void OnButton()
    {
        Debug.Log(user.text + " On Login");
        Debug.Log(pass.text + " On Login");

        Employee emp1 = new Employee(user.text, pass.text);
        SharedFolderProxy folderProxy = new SharedFolderProxy(emp1);
        folderProxy.PerformRWOperations();
        info.text = folderProxy.PerformRWOperations();
    }
}
