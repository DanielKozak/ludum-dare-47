using UnityEngine;
[System.Serializable]
public class Skill
{
    public int ID;
    public string Name;
    public string Descr;

    public int cooldown;
    public int unlockLevel;

    public Sprite icon;

    public string effectsDescr;

    public virtual void ApplyEffects(ShipController target = null) { }

}