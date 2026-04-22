using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f; // Prêdkoœæ poruszania siê gracza
    Vector2 movementInput;
    //GameObject levelManager; // Referencja do obiektu LevelManager
    void Start()
    {
        //levelManager = GameObject.Find("LevelManager"); // ZnajdŸ obiekt LevelManager w scenie
    }
    void OnMove(InputValue value)
    {
        //pobierz stan wejœcia i zapisz go w movementInput
        movementInput = value.Get<Vector2>();
        //Debug.Log("Move: " + movementInput);
    }
    void Update()
    {
        //przesuñ gracza o movementInput * Time.deltaTime
        transform.Translate(movementInput * Time.deltaTime * speed);
        if(transform.position.x < -9f) 
            transform.position = new Vector3(-9f, -4, 0);
        if(transform.position.x > 9f) 
            transform.position = new Vector3(9f, -4, 0);
    }
    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("Player collided with: " + collision.gameObject.name);
        Destroy(collision.gameObject); // Destroy the object we collided with
        // Dodaj punkty za zniszczenie obiektu
        LevelManager.Instance.AddPoints(); 
    }
}
