using TMPro;
using UnityEngine;

public class MainMenuManager : MonoBehaviour
{
    public GameObject highScoreText; // Referencja do obiektu tekstowego, który bêdzie wyœwietla³ najwy¿szy wynik
    public void Start()
    {
       highScoreText.GetComponent<TextMeshProUGUI>().text = 
            "High score: " + GameManager.Instance.highScore; // Ustaw tekst na najwy¿szy wynik z GameManagera
    }
    public void NewGame()
    {
        GameManager.Instance.NewGame();
    }
    public void ExitGame()
    {
        GameManager.Instance.ExitGame();
    }
}
