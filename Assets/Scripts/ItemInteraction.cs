using UnityEngine;

public class ItemInteraction : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Item")
        {
            ScoreSystem.UpdateScore(100);
            Destroy(other.gameObject);
        }
    }
}
