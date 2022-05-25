using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody Rb;
    private float RightBoundary = 4.8f;
    private float LeftBoundary = -5.0f;

    private float HigherBoundary = 5.0f;
    private float LowerBoundary = -5.0f;

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        LevelBoundaries();
        Rb.velocity = new Vector3(Input.GetAxis("Horizontal"), Rb.velocity.y, Input.GetAxis("Vertical"));
    }

    private void LevelBoundaries()
    {
        float XPos = transform.position.x;
        float ZPos = transform.position.z;

        //Position of character is outside of the allowed space
        if (XPos >= RightBoundary)
            XPos = RightBoundary;

        else if (XPos <= LeftBoundary)
            XPos = LeftBoundary;

        if (ZPos >= HigherBoundary)
            ZPos = HigherBoundary;

        else if (ZPos <= LowerBoundary)
            ZPos = LowerBoundary;

        transform.position = new Vector3(XPos, transform.position.y, ZPos);
    }
}
