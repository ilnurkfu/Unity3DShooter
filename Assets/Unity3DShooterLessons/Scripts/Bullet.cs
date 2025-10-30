using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float deathTimer;
    [SerializeField] private float bulletSpeed;
    [SerializeField] private int bulletDamage;

    [SerializeField] private Rigidbody rb;

    private void Start()
    {
        Destroy(gameObject, deathTimer);
    }

    public void Shoot()
    {
        rb.AddForce(transform.forward * bulletSpeed, ForceMode.Impulse);
    }

    private void OnTriggerEnter(Collider other)
    {
        var newArmor = other.GetComponent<Armor>();
        if (newArmor != null)
        {
            newArmor.ApplyDamage(bulletDamage);
        }
        var newEnemy = other.GetComponent<EnemyPart>();
        if(newEnemy != null)
        {
            newEnemy.TranslateDamage(bulletDamage);
        }
        Destroy(gameObject);
    }
}
