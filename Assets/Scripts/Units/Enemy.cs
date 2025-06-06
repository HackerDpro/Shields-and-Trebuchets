using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 50;
    public float speed = 2f;

    void Update()
    {
        // placeholder: beweeg naar links
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    public void TakeDamage(int dmg)
    {
        health -= dmg;
        if (health <= 0) Destroy(gameObject);
    }
}
