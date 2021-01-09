using UnityEngine;

public class BasicUnit : MonoBehaviour
{
    [SerializeField]
    protected string unitName;

    [SerializeField]
    protected int moveAmount = 5;

    [SerializeField]
    protected int startingHealth = 10;

    private int health;

    private void Awake()
    {
        health = startingHealth;
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
