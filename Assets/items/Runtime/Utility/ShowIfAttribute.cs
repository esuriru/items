using System;

using UnityEngine;

using Esuriru.Items.Utility.Extensions;

namespace Esuriru.Items.Utility
{
    [AttributeUsage(AttributeTargets.Field)]
    public class ShowIfAttribute : PropertyAttribute
    {
        // TODO - Add comment
        public enum Type
        {
            Hide,
            ReadOnly
        }

        public string Name { get; private set; }

        public object Value { get; private set; }

        public Type DisableType { get; private set; }

        /// <summary>
        /// ShowIfAttribute constructor  
        /// </summary>
        /// <param name="name">Name of the field/property</param>
        /// <param name="value">Value of the field/property</param>
        /// <param name="property">Is attribute on property</param>
        /// <param name="disableType">Type of disable</param>
        public ShowIfAttribute(string name, object value,
            bool property = false, Type disableType = Type.Hide)
        {
            Name = property ? name.BackingField() : name;

            Value = value;
            DisableType = disableType;
        }
    }
}
