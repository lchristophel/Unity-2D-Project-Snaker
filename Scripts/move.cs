using System.Collections;
using UnityEngine;

public class move : MonoBehaviour
{
    public float Speed;
    public float rotationSpeed;

    public float velocityX;

    private void Update()
    {
        velocityX = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        transform.Translate(Vector2.up * Speed * Time.fixedDeltaTime, Space.Self);
        transform.Rotate(Vector3.forward * -velocityX * rotationSpeed * Time.fixedDeltaTime);
    }
}
