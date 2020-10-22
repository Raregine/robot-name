using System;
using System.Collections.Generic;

public class Robot
{
    private string name;
    private char[] robotName = new char[5];
    private static List<string> allRobotNames = new List<string>();
    private String finalName; 
    private Random rdm = new Random();
    private static string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private static string nums = "1234567890";

    public Robot()
    {
        this.name = GetNewName();
        allRobotNames.Add(this.name);
    }

    private string GetNewName()
    {
        for (int i = 0; i < 2; i++)
        {
            this.robotName[i] = chars[rdm.Next(0, chars.Length)];
        }
        for (int i = 2; i < 5; i++)
        {
            this.robotName[i] = nums[rdm.Next(0, nums.Length)];
        }
        finalName = new String(robotName);
        while (isDuplicate() == true) Reset();
        return finalName;
    }

    private bool isDuplicate()
    {
        if (allRobotNames.Contains(finalName)) return true;
        else return false;
    }

    public string Name
    {
        get {return name;}
    }

    public void Reset()
    {
        this.name = GetNewName();
    }
}