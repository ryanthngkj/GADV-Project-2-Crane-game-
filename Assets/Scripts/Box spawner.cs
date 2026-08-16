using UnityEngine;

public class Boxspawner : MonoBehaviour
{
    public Transform spawnPoint; 
    public GameObject[] itemPrefabs; //List to put the reserved prefabs in (If i put the ones in the scene,
                                     //once they get deleted the code cannot refer to them anymore)
    public void SpawnBox() //Public function for the button to call 
    {
        int itemIndex = Random.Range(0, itemPrefabs.Length); //This chooses what box to spawn at random from the list
        Instantiate(itemPrefabs[itemIndex], spawnPoint.position, Quaternion.identity);
    } //Create a copy of the selected box^, at the spawn point^, with no rotation^
}
