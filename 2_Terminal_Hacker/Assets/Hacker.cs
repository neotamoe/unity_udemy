﻿using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Game Configuration
    string[] level1Passwords = { "braeburn", "delicious", "granny", "pinkLady", "red", "green" };
    string[] level2Passwords = { "analyst", "tester", "owner", "developer", "scrum", "agile" };
    string[] level3Passwords = { "formula", "chemical", "monolayer", "lipid", "membrane", "labcoat" };

        // Game State
    int level;
    string password;

    enum Screen {  MainMenu, Password, Win };
    Screen currentScreen;

    // Start is called before the first frame update
    void Start()
    {
        print("Hello, Console");
        ShowMainMenu();
    }

    void ShowMainMenu ()
    {
        currentScreen = Screen.MainMenu;
        level = 0;
        password = "";
        Terminal.ClearScreen();
        Terminal.WriteLine("Hello Hacker.");
        Terminal.WriteLine("Select your target:");
        Terminal.WriteLine("1. Fruit Stand");
        Terminal.WriteLine("2. Tech Startup");
        Terminal.WriteLine("3. Science Lab");
        Terminal.WriteLine("Enter your selection:");

    }

    void OnUserInput(string input)
    {
        if (input == "menu")
        {
            ShowMainMenu();
        }
        else if (currentScreen == Screen.MainMenu) {
            RunMainMenu(input);
        } else if (currentScreen == Screen.Password)
        {
            CheckPassword(input);
        }
    }

    void RunMainMenu(string input)
    {
        bool isValidLevel = (input=="1" || input=="2" || input=="3");
        if (isValidLevel)
        {
            level = int.Parse(input);
            StartGame();
        }
        else if (input == "007")
        {
            Terminal.WriteLine("Welcome, Agent Bond.");        
        }
        else
        {
            Terminal.WriteLine("Select a valid level");
        }
    }

    void StartGame()
    {
        currentScreen = Screen.Password;
        Terminal.ClearScreen();
        switch (level)
        {
            case 1:
                password = level1Passwords[Random.Range(0, level1Passwords.Length)];
                break;
            case 2:
                password = level2Passwords[Random.Range(0, level2Passwords.Length)];
                break;
            case 3:
                password = level3Passwords[Random.Range(0, level3Passwords.Length)];
                break;
            default:
                Debug.LogError("Error setting password.");
                break;
        }
        Terminal.WriteLine("Please enter your password: ");
    }

    void CheckPassword(string input)
    {
        if(input == password)
        {
            DisplayWinScreen();
        }
        else
        {
            Terminal.WriteLine("Wrong.  Please try again.");
        }
    }

    void DisplayWinScreen()
    {
        currentScreen = Screen.Win;
        Terminal.ClearScreen();
        ShowLevelReward();
    }

    void ShowLevelReward()
    {
        switch(level)
        {
            case 1:
                Terminal.WriteLine("Congratulations!  Have an apple...");
                Terminal.WriteLine(@"

 _|/_
/    \
\    /
 \__/
"
                );
                break;
            case 2:
                Terminal.WriteLine("Congratulations!  Here's a computer...");
                Terminal.WriteLine(@"
_________
| _____  |
| |    | |
| |____| |
|________|
\:::::::::\
 \:::::::::\
  ----------
"
                );
                break;
            case 3:
                Terminal.WriteLine("Congratulations!  Have a flask...");
                Terminal.WriteLine(@"
 ___
 | |
 | |
 /  \
/    \   
\____/
"
);
                break;
            default:
                Debug.LogError("Unknown level reached.");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        // this can be a good place to check a function like this
         //int index = Random.Range(0, level1Passwords.Length);
         //print(index);
    }

}
