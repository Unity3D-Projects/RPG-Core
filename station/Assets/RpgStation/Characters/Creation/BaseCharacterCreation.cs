﻿using UnityEngine;

namespace Station
{
    public abstract class BaseCharacterCreation : ScriptableObject
    {
        public abstract void Init(RpgStation station);
        public abstract bool HasData();
        public abstract void StartSequence();
        public abstract string Description();
    }

}

