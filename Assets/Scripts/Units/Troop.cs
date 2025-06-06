using UnityEngine;
using UnityEngine.AI;

public class Troop : MonoBehaviour
{
    public int health = 100;
    public int damage = 10;
    public float speed = 3f;

    void Update()
    {
        // placeholder: beweeg naar rechts
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        if (health <= 0) Destroy(gameObject);
    }
}
