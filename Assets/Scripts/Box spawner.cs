//using UnityEngine;
//
//public class Boxspawner : MonoBehaviour
//{
//    public Transform[] spawnPoints;
//    public GameObject[] itemPrefabs;
//
//    
//    void Start()
//    {
//        StartCoroutine(spawnItem());
//    }
//
//    private IEnumerator spawnItem()
//    {
//        while(true)
//        {
//            int currentSpawnIndex = Random.Range(0, spawnPoints.Length);
//            Transform transform = spawnPoints[currentSpawnIndex];
//
//            int itemIndex = Random.Range(0, itemPrefabs.Length);
//            Instantiate(itemPrefabs[itemIndex], transform.position);
//        }
//    }

//    void Update()
//    {
//        
//    }
//}
