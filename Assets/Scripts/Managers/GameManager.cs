using UnityEngine;

public class ResourceManager : MonoBehaviour
{
    public static ResourceManager Instance;
    public int gold = 100;
    public int wood = 50;
    public int food = 50;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    public void AddGold(int amount) => gold += amount;
    public void SpendGold(int amount) => gold -= amount;
}
