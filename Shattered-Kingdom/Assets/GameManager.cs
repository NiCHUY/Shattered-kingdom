using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using Unity.VisualScripting;
using UnityEngine;


public class GameManager : MonoBehaviour
{ 
    public static int day = 1, month = 1, year = -1000;
    public static int speed = 1;
    
#region Calendar
IEnumerator DateSetter()
    {
        for (;;)
        {   if (day < 30) { 
                day++;
                foreach (Island tile in TileList.tileList)
                {
                    tile.PopulationGrowth();
                    tile.LoyaltyUpdate();
                    tile.LifeQualityUpdate();
                }
            } else { if (month < 12) { 
                    day = 1;month++;
                    foreach (Island tile in TileList.tileList)
                    {
                        tile.PopulationGrowth();
                        tile.LoyaltyUpdate();
                        tile.LifeQualityUpdate();
                    }
                }
                else { if (year == -1) { day = 1; month = 1; year = 1; }else {
                        day = 1; month = 1; year++; 
                    }
                    foreach (Island tile in TileList.tileList)
                    {
                        tile.PopulationGrowth();
                        tile.LoyaltyUpdate();
                        tile.LifeQualityUpdate();
                    }
                }
            }
            yield return new WaitForSeconds(1f / speed);
        }
        // ReSharper disable once IteratorNeverReturns
    }

#endregion

    void Start()
    {
        DateSetter();
    }
    
    void Update()
    {
        
    }
}
