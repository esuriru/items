using UnityEngine;
using System;

namespace Esuriru.Items
{
    public abstract class ItemBehaviour<T> : ScriptableObject
    {
        public virtual void OnUse(T user) {}
    }
}