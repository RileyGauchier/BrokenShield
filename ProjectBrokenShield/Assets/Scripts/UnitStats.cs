using UnityEngine;

[CreateAssetMenu(fileName ="New Unit Stats", menuName ="UnitStats")]
public class UnitStats : ScriptableObject
{    
    public string unitName;
    public string description;

    public int moveAmount;
    public int startingHealth;
    public int armor;
    public int strength;
}
