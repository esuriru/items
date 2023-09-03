using UnityEngine;

using Esuriru.Items.Utility.ExtensionMethods;

namespace Esuriru.Items
{
    [CreateAssetMenu(fileName = "New Item", 
        menuName = "items/Scriptable Objects/Item Base")]
    public class ItemBase : ScriptableObject 
    {
        #region Public 

        /// <summary>
        /// Name of the item 
        /// </summary>
        public string Name 
        { 
            get 
            {
                // In the event that the name is not filled in at runtime,
                // through one of Unity's message methods, initialize
                // the name before returning  
                if (string.IsNullOrWhiteSpace(_name))
                {
                    InitName(false);
                }
                return _name;
            }
            protected set 
            {
                _name = value;
            }
        }

        #endregion

        #region Private 

        [SerializeField]
        private string _name;
    
        /// <summary>
        /// Editor only unity message to fill in `Name` property
        /// </summary>
        private void OnValidate()
        {
            InitName();
        }

        /// <summary>
        /// Editor and runtime unity message to fill in `Name` property
        /// </summary>
        private void OnEnable()
        {
            InitName();
        }

        private void InitName(bool checkEmpty = true)
        {
            // TODO: Add the option to choose whether
            // to preserve acronyms
            if (!checkEmpty || string.IsNullOrWhiteSpace(_name))
            {
                _name = name.ToSentence(true);
            }
        }

        #endregion
    }
}
