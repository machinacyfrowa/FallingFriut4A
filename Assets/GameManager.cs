using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static GameManager Instance; // Singleton instance
    public int highScore = 0;
    void Awake()
    {
        //je¿eli nie mamy w grze gameManagera, to ten obiekt
        //staje siê instancj¹ singletona i nie jest niszczony przy zmianie sceny
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            //jeœli ju¿ mamy w grze gameManagera, to ten obiekt jest niszczony,
            //¿eby nie by³o dwóch instancji
            Destroy(gameObject);
        }
        PlayerPrefs.GetInt("HighScore", 0); // Pobierz zapisany wynik z PlayerPrefs, domyœlnie 0
    }
    public void NewGame()
    {
        SceneManager.LoadScene("Level1"); // Za³aduj scenê o nazwie "Level1"
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu"); // Za³aduj scenê o nazwie "MainMenu"
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void SetHighScore(int score)
    {
        if(score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("HighScore", highScore);
            //zapomnieliœmy o zapisaniu zmian!!!
            PlayerPrefs.Save();
        }
    }
}
