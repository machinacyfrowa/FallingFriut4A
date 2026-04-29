using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    GameManager Instance; // Singleton instance
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
    }
    public void NewGame()
    {
        SceneManager.LoadScene("Level1"); // Za³aduj scenê o nazwie "Level1"
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
