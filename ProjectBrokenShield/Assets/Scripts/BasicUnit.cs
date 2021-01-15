using UnityEngine;

public class BasicUnit : MonoBehaviour
{
    [SerializeField] UnitStats unitStats;

    private void Awake()
    {
        unitStats.health = unitStats.startingHealth;
    }

    public void TakeDamage(int amount)
    {
        unitStats.health -= amount;
        if(unitStats.health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}
