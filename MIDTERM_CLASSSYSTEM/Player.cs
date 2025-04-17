using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    public string name;
    public int level;
    public Player()
    {
        name = "";
        level = 0;
    }

    public Player(string name)
    {
        this.name = name;
        level = 0;
    }

    public Player (int level)
    {
        name = "No name";
        this.level = level;
    }

    public Player(string name, int level)
    {
        this.name = name;
        this.level = level;
    }
}
