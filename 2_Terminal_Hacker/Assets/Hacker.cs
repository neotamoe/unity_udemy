using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Hello, Console");
        ShowMainMenu("Hello, Hacker Neota.");
    }

    void ShowMainMenu (string greeting)
    {
        Terminal.ClearScreen();
        Terminal.WriteLine(greeting);
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
            Terminal.WriteLine("Let's hack the fruit stand!");
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
