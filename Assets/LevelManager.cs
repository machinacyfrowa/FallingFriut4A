using TMPro;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager Instance; // Singleton instance

    int points = 0; // Variable to keep track of points
    //referencja do obiektu tekstowego, który bêdzie wyœwietla³ punkty
    public GameObject pointsCounter;
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
    }
    public void AddPoints(int amount = 1)
    {
        points += amount; // zwiêksz iloœæ punktów o podan¹ wartoœæ (domyœlnie 1)
    }
}
