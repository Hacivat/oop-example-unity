using UnityEngine;

public abstract class Damagable : MonoBehaviour, ITakeDamage
{
    [SerializeField] private int maxHealth;

    private int health;

    private void Awake ()
    {
        health = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
            Destroy(gameObject);
    }
}
