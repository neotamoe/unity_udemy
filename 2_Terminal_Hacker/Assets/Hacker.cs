using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Game State
    int level;

    // Start is called before the first frame update
    void Start()
    {
        print("Hello, Console");
        ShowMainMenu();
    }

    void ShowMainMenu ()
    {
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
        } else if (input=="1")
        {
            level = 1;
            Terminal.WriteLine("You chose level 1. Let's hack the fruit stand!");
        } else if (input=="2")
        {
            level = 2;
            Terminal.WriteLine("You chose level 2. Let's hack the startup.");
        }
        else if (input == "3")
        {
            level = 3;
            Terminal.WriteLine("You chose level 3. Let's hack the lab.");
        }
        else
        {
            Terminal.WriteLine("Select a valid level");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
