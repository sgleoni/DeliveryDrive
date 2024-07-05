using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 200f;
    [SerializeField] float moveSpeed = 5f;

    void Start()
    {
        
    }

    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal");
        float moveAmount = Input.GetAxis("Vertical");
        transform.Rotate(0, 0, -steerAmount * steerSpeed * Time.deltaTime);
        transform.Translate(0, moveSpeed * moveAmount * Time.deltaTime, 0);
    }
}
