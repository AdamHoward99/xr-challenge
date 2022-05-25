using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public Transform[] ItemSpawnPoints;
    public GameObject Item;

    // Start is called before the first frame update
    void Start()
    {
        foreach(Transform T in ItemSpawnPoints)
        {
            Instantiate(Item, T.position, Quaternion.identity);
        }
    }
}
