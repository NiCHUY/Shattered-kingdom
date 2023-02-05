using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;
using Random = System.Random;

public class Island : MonoBehaviour
{
#region Variables
    public Country country;
    public int population;
    public int education;
    public float gpm;
    public float maxHeight;
    public float minHeiht;
    public new String name;
    public int archipelago;
    public Resourses resourses;

    public int posX;
    public int posY;
    public int posZ;
    
    private float _lifeQuality;
    private float _loyalty;
    private float _income;
    
    private bool _flyingUp = true;
    private Random _random = new Random();
        
    #region Resourses
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
#endregion

#region Constructor
    public Island(Country country, String name, int population, int education, float gpm)
        {
            this.country = country;
            this.name = name;
            this.population = population;
            this.education = education;
            this.gpm = gpm;
            this.resourses = new Resourses(bread, groceries, fish, meat, wood, sand, quartz, coat, material, bronze, iron, explosiveStones);
        }
    
        public Island(Country country, String name, int population, int education, float gpm, Resourses resources)
        {
            this.country = country;
            this.name = name;
            this.population = population;
            this.education = education;
            this.gpm = gpm;
            this.resourses = resources;
        }
#endregion

#region Updater
public int PopulationGrowth()
    {
        return (int)((population * ((gpm / population) * _lifeQuality)) / 100);
    }

    public void LifeQualityUpdate()
    {
        _lifeQuality = (gpm / population) * education;
    }
    
    public void LoyaltyUpdate()
    {
        _loyalty = 100f;
    }

    public void PositionUpdate()
    {
        if (_flyingUp)
        {
            transform.Translate(new Vector3(0f, 0.005f, 0f));
            if (transform.position.y > maxHeight) _flyingUp = false;
        }
        else
        {
            transform.Translate(new Vector3(0f, -0.005f, 0f));
            if (transform.position.y < minHeiht) _flyingUp = true;
        }
    }
#endregion

    public Country getCountry()
    {
        return this.country;
    }

    void Start()
    {
        TileList.tileList.Add(this);
    }

    void Update()
    {
        PositionUpdate();
    }
}
