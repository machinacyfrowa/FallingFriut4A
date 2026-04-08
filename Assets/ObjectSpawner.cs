using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectPrefab; // The prefab to spawn
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnObject", 0f, 1f); // Spawn an object every 1 seconds
    }
    void SpawnObject()
    {
        //tworzymy sobie losowy punkt nad widoczn¹ czêœci¹ ekranu
        //pomiêdzy jego lew¹ i praw¹ krawêdzi¹
        Vector3 spawnPosition = new Vector3(Random.Range(-9f, 9f), 10f, 0f);
        // Instantiate the object at the spawner's position and rotation
        GameObject spawnedObject = Instantiate(objectPrefab,
                                                //podstawiamy nasz¹ losow¹ pozycjê, a nie pozycjê spawner'a
                                                spawnPosition,  
                                                transform.rotation); 
        Destroy(spawnedObject, 5f); // Destroy the spawned object after 5 seconds
    }
}
