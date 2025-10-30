using UnityEngine;

[CreateAssetMenu(fileName = "Gun", menuName = "Scriptable Objects/Gun")]
public class Gun : ScriptableObject
{
    [SerializeField] int maxAmmo;
    [SerializeField] int clipSize;
    [SerializeField] int baseDamage;

    [SerializeField] float reloadTime;



    [SerializeField] WeaponType weaponType;

    [SerializeField] Mesh mesh;
}

public enum WeaponType
{
    first,
    second
}
