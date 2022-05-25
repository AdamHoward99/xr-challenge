using UnityEngine;

public class ItemInteraction : MonoBehaviour
{
    public AudioSource SFX;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Item")
        {
            SFX.Play();
            ScoreSystem.UpdateScore(100);
            Destroy(other.gameObject);
        }
    }
}
