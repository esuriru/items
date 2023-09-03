using UnityEngine;

namespace Esuriru.Items
{
    [CreateAssetMenu(fileName = "New Item", 
        menuName = "items/Scriptable Objects/Item Base")]
    public class ItemBase : ScriptableObject 
    {
        #region Public 

        /// <summary>
        /// Name of the item that uses the name of the Scriptable Object
        /// </summary>
        public string Name 
        { 
            get 
            {
                if (string.IsNullOrEmpty(_name))
                {

                }
                return _name;
            }
            protected set 
            {

            }
        }

        #endregion

        #region Private 

        private string _name;

        #endregion
    }
}
