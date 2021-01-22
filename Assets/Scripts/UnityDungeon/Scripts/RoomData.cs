using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityDungeon
{
    [CreateAssetMenu(fileName = "New Room", menuName = "CustomScripts/Room")]
    public class RoomData : ScriptableObject
    {
        public ScriptableObject occupant;
        public RoomData roomLeft;
        public RoomData roomRight;
        [TextArea(4, 10)]
        public string description;
    }
}
