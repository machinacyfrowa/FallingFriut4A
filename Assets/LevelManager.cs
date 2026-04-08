using TMPro;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    int points = 0; // Variable to keep track of points
    //referencja do obiektu tekstowego, który bêdzie wyœwietla³ punkty
    public GameObject pointsCounter;

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
