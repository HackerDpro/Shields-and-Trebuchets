using UnityEngine;

public class Crop : MonoBehaviour
{
    public float growTime = 10f;
    private float timer;
    private bool isGrown = false;

    void Update()
    {
        if (!isGrown)
        {
            timer += Time.deltaTime;
            if (timer >= growTime)
            {
                isGrown = true;
                Debug.Log("Gewas is volgroeid!");
            }
        }
    }

    public void Harvest()
    {
        if (isGrown)
        {
            ResourceManager.Instance.food += 10;
            Destroy(gameObject);
        }
    }
}
