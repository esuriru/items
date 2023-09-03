using UnityEngine;

[CreateAssetMenu(fileName = "New Item", 
    menuName = "items/Scriptable Objects/Item Base")]
public class ItemBase : ScriptableObject 
{
    [field: SerializeField]
    public string Name { get; protected set; }
}