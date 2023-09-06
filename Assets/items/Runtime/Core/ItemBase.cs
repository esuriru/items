using UnityEngine;

using Esuriru.Items.Utility.Extensions;
using Esuriru.Items.Utility;

namespace Esuriru.Items
{
    [CreateAssetMenu(fileName = "New Item", 
        menuName = "items/Scriptable Objects/Item Base")]
    public class ItemBase : ScriptableObject
    {
        #region Serialized

        [SerializeField]
        private bool _enableCustomName;

        [ShowIf("_enableCustomName", true, disableType: 
            ShowIfAttribute.Type.ReadOnly)]
        [SerializeField]
        private string _name;
    
        #endregion
         
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

        /// <summary>
        /// Editor only unity message to fill in `Name` property
        /// </summary>
        private void OnValidate()
        {
            Init();
        }

        /// <summary>
        /// Editor and runtime unity message to fill in `Name` property
        /// </summary>
        private void OnEnable()
        {
            Init();
        }

        /// <summary>
        /// Initialization function
        /// </summary>
        private void Init()
        {
            // When custom name is enabled, we want to keep checking whether
            // the name is empty or not
            // When it is not enabled, we do not have to check because it
            // will be forced to initialize with the name
            // of the Scriptable Object
            InitName(_enableCustomName);
        }

        /// <summary>
        /// Initializes the name field
        /// </summary>
        /// <param name="checkEmpty">Preliminary check</param>
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
