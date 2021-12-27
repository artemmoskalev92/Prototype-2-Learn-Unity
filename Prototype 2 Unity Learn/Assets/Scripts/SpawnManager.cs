using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 15;
    private float spawnRangeZ = 9;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 3f;
    
    

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimalTop", startDelay, spawnInterval);
        InvokeRepeating("SpawnRandomAnimalRight", startDelay, spawnInterval);
        InvokeRepeating("SpawnRandomAnimalLeft", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void SpawnRandomAnimalTop()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
    void SpawnRandomAnimalRight()
    {
        Vector3 spawnRight = new Vector3(spawnRangeX, 0, Random.Range(-spawnRangeZ, spawnRangeZ));
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 LeftRotation = new Vector3(0, -90, 0);
        Instantiate(animalPrefabs[animalIndex], spawnRight, Quaternion.Euler(LeftRotation));
    }
    void SpawnRandomAnimalLeft()
    {
        Vector3 spawnLeft = new Vector3(-spawnRangeX, 0, Random.Range(-spawnRangeZ, spawnRangeZ));
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 rightRotation = new Vector3(0, 90, 0);
        Instantiate(animalPrefabs[animalIndex], spawnLeft, Quaternion.Euler(rightRotation));
    }
}
