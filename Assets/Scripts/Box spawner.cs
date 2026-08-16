//using UnityEngine;
//
//public class Boxspawner : MonoBehaviour
//{
//    public Transform[] spawnPoints;
//    public GameObject[] itemPrefabs;

    
//    void Start()
//    {
//        StartCoroutine(spawnItem());
//    }

//    private IEnumerator spawnItem()
//    {
//        while(true)
//        {
//            int currentSpawnIndex = Random.Range(0, spawnPoints.Length);
//            Transform transform = spawnPoints[currentSpawnIndex];
//
//            int itemIndex = Random.Range(0, itemPrefabs.Length);
//            Instantiate(itemPrefabs[itemIndex], transform.position, Quaternion.identity);
//            yield return new WaitForSeconds(1f);
//        }
 //   }
//
//    void Update()
//    {
        
//    }
//}

using UnityEngine;

public class Boxspawner : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject[] itemPrefabs; // Assign your 3 colored box prefabs here

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int itemIndex = Random.Range(0, itemPrefabs.Length);
            Instantiate(itemPrefabs[itemIndex], spawnPoint.position, Quaternion.identity);
        }
    }
}
