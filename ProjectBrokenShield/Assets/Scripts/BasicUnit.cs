using UnityEngine;

public class BasicUnit : MonoBehaviour
{
    [SerializeField] private UnitStats unitStats;

    private int health;

    private void Awake()
    {
        health = unitStats.startingHealth;
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        if(health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}
