using System;
using System.Collections;
using UnityEngine;

namespace DefaultNamespace
{
    public class TileList: MonoBehaviour
    {
        public static ArrayList tileList = new ArrayList();
        public int ID;

        public Island getTile(int ID)
        {
            return (Island)tileList[ID];
        }
            
    }
}