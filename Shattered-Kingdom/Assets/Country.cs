using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.UI;

public class Country : MonoBehaviour 
{
    public new String countryName;
    private ArrayList _islandUnderControl;
    private float _countryMoney;
    private float _educatedPeople;
    private float _population;
    public Texture flag;

    public Country(String countryName)
    {
        this.countryName = countryName;
        this._islandUnderControl = new ArrayList();
        foreach (Island island in TileList.tileList)
        {
            if (countryName.Equals(island.getCountry().countryName))
            {
                _islandUnderControl.Add(island);
                TileList.tileList.Remove(island);
            }
        }

        foreach (Island island in _islandUnderControl)
        {
            _countryMoney += island.gpm;
            _educatedPeople += island.education;
            _population += island.population;
        }
    }

    public void Update()
    {
        
    }
}
