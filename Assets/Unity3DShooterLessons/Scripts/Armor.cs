using System;
using UnityEngine;

public class Armor : MonoBehaviour
{
    [SerializeField] private int health;

    [SerializeField] private float brokenFactor;
    [SerializeField] private float damageScaler;

    [SerializeField] private EnemyPart enemyPart;

    public void ApplyDamage(int newDamage)
    {
        health -= (int)(newDamage * brokenFactor);

        enemyPart.TranslateDamage((int)(newDamage / damageScaler));

        if(health <= 0)
        {
            Died();
        }

        int[] mass = new int[health];
        Array.Sort(mass);
    }

    private void Died()
    {
        Destroy(gameObject);
    }
}
