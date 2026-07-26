using UnityEngine;
using TMPro;

public class Boxcounter : MonoBehaviour
{
    public static Boxcounter instance;
    public TextMeshProUGUI counterText;
    private int counter = 0;

    void Awake()
    {
        instance = this;
        counterText.text = "Score: ";
    }

    public void AddPoint()
    {
        counter++;
        counterText.text = "Score: " + counter;
    }
}
