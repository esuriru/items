using UnityEngine;
using System;

namespace Esuriru.Items
{
    // NOTE - Maybe have a way to have custom item behaviour through System.Action(s)?
    public abstract class ItemBehaviour<T> : ScriptableObject
    {
        public virtual void OnUse(T user) {}
    }
}