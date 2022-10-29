using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISharedFolder 
{
    string PerformRWOperations();
}

public class SharedFolder : ISharedFolder
{
    public string PerformRWOperations()
    {
        return "Performing Read Write Ops on Shared Folder";
    }
}

class SharedFolderProxy : ISharedFolder
{
    private ISharedFolder folder;
    private Employee employee;

    public SharedFolderProxy (Employee emp)
    {
        employee = emp;
    }

    public string PerformRWOperations()
    {
        if (employee.Role == "Developer")
        {
            folder = new SharedFolder();
            folder.PerformRWOperations();
            return "Shared Folder Proxy makes call to RealFolder PerformRWOperations method";
        }
        else
        {
            return "You do not have permission to access this folder";
        }
    }
}
