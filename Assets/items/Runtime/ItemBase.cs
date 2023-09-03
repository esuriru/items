using UnityEngine;

[CreateAssetMenu(fileName = "New Item", 
    menuName = "items/Scriptable Objects/Item Base")]
public class ItemBase : ScriptableObject 
{
    #region Public 

    /// <summary>
    /// Name of the item that uses the name of the Scriptable Object
    /// </summary>
    [field: SerializeField]
    public string Name { get; protected set; }

    #endregion

    #region Protected

    protected void OnEnable()
    {

    }

    #endregion
}