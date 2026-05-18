using System;
using System.Collections.Generic;


public class Prompts
{

    public List<string> _prompts = new List<string>();

    public string RandomPromt()
    {

        _prompts.Add("What was your most significant spiritual experience today");
        _prompts.Add("Which goals did you accomplish today?");
        _prompts.Add("What areas of your life would you like to refine");
        _prompts.Add("What blessing did you recognize today");
        _prompts.Add("What would you like to improve upon tomorrow");

        Random promptRandom = new Random();
        int idRandom = promptRandom.Next(_prompts.Count);
        string choseVisual = _prompts[idRandom];
        return choseVisual;
    }
}