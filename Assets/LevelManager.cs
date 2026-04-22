using TMPro;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager Instance; // Singleton instance

    int points = 0; // Variable to keep track of points
    int lives = 3; // Variable to keep track of lives
    //referencja do obiektu tekstowego, który bêdzie wyœwietla³ punkty
    public GameObject pointsCounter;
    //referencja do obiektu tekstowego, który bêdzie wyœwietla³ iloœæ ¿yæ
    public GameObject livesCounter;
    //referencja do panelu z komunikatem o przegranej
    public GameObject gameOverPanel;
    //awake uruchamia sie przed startem, jest idealnym miejscem do implementacji singletona
    void Awake()
    {
        // Implementacja singletona
        if (Instance == null)
        {
            Instance = this; // Instancja nie istnieje - ustawiamy instancjê na ten obiekt
        }
        else
        {
            Destroy(gameObject); // Jeœli instancja ju¿ istnieje, zniszcz ten obiekt
        }
    }

    void Update()
    {
        pointsCounter.GetComponent<TextMeshProUGUI>().text = 
                "Punkty: " + points; // Update the text of the points counter
        livesCounter.GetComponent<TextMeshProUGUI>().text =
                "¯ycia: " + lives; // Update the text of the lives counter
    }
    public void AddPoints(int amount = 1)
    {
        points += amount; // zwiêksz iloœæ punktów o podan¹ wartoœæ (domyœlnie 1)
    }
    public void LoseLife()
    {
        lives--; // zmniejsz iloœæ ¿yæ o 1
        if (lives <= 0)
        {
            Time.timeScale = 0; // Zatrzymaj grê
            gameOverPanel.SetActive(true); // Wyœwietl panel Game Over
        }
    }
}
