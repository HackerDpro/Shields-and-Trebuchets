using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text goldText;
    public Text foodText;
    public Text dayText;

    void Update()
    {
        goldText.text = "Goud: " + ResourceManager.Instance.gold;
        foodText.text = "Voedsel: " + ResourceManager.Instance.food;
        dayText.text = "Dag: " + GameManager.Instance.currentDay;
    }
}
