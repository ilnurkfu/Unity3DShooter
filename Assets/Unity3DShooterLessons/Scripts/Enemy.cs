using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : CharacterData
{
    [SerializeField] private float attackTimer;

    //[SerializeField] private CharacterData player;

    //private void Update()
    //{
    //    if (attackTimer > 0)
    //    {
    //        attackTimer -= Time.deltaTime;
    //    }
    //    else
    //    {
    //        player.ApplyDamage(int.MaxValue);
    //    }
    //}
}
