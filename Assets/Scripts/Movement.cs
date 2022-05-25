using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody Rb;

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        Rb.velocity = new Vector3(Input.GetAxis("Horizontal"), Rb.velocity.y, Input.GetAxis("Vertical"));
    }
}
