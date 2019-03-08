using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Game Configuration
    string[] level1Passwords = { "braeburn", "delicious", "granny", "pinkLady", "red", "green" };
    string[] level2Passwords = { "analyst", "tester", "owner", "developer", "scrum", "agile" };
    string[] level3Passwords = { "formula", "chemical", "monolayer", "lipid", "membrane", "labcoat" };

        // Game State
    int level;
    string password;

    enum Screen {  MainMenu, Password, Win};
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
        if (input == "1")
        {
            level = 1;
            password = level1Passwords[2];
            StartGame();
        }
        else if (input == "2")
        {
            level = 2;
            password = level2Passwords[3];
            StartGame();
        }
        else if (input == "3")
        {
            level = 3;
            password = level3Passwords[5];
            StartGame();
        }
        else
        {
            Terminal.WriteLine("Select a valid level");
        }
    }

    void StartGame()
    {
        currentScreen = Screen.Password;
        Terminal.WriteLine("You chose level " + level);
        Terminal.WriteLine("Please enter your password: ");
    }

    void CheckPassword(string input)
    {
        if(input == password)
        {
            Terminal.WriteLine("Congratulations!  Correct Password.");
        } 
        else
        {
            Terminal.WriteLine("Wrong.  Please try again.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
