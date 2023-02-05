using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resourses
{
#region Variables
    public int bread;
    public int groceries;
    public int fish;
    public int meat;
    public int wood;
    public int sand;
    public int quartz;
    public int coat;
    public int material;
    public int bronze;
    public int iron;
    public int explosiveStones;
#endregion

#region Constructor

public Resourses(int bread,
        int groceries,
        int fish,
        int meat,
        int wood, 
        int sand,
        int quartz,
        int coat,
        int material,
        int bronze,
        int iron,
        int explosiveStones)
    {
        this.bread = bread;
        this.groceries = groceries;
        this.fish = fish;
        this.meat = meat;
        this.wood = wood;
        this.sand = sand;
        this.quartz = quartz;
        this.coat = coat;
        this.material = material;
        this.bronze = bronze;
        this.iron = iron;
        this.explosiveStones = explosiveStones;
    }
#endregion    
    
}
