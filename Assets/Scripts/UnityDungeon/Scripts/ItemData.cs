using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityDungeon
{
    [CreateAssetMenu(fileName = "New Item", menuName = "CustomScripts/Item")]
    public class ItemData : ScriptableObject
    {
        public int incrementStrength;
        public int incrementIntelligence;
        public int incrementDefense;
        public int incrementHP;
        public new string name;
    }
}
