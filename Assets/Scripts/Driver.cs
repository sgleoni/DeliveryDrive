using UnityEngine;

public class Driver : MonoBehaviour
{
    const float TIMER_START = 5f;

    [SerializeField] float steerSpeed = 300f;
    [SerializeField] float moveSpeed = 20f;
    [SerializeField] float slowSpeed = 15f;
    [SerializeField] float boostSpeed = 30f;
    float currentSpeed;
    float speedTimer;
    bool speedChange;

    void Start()
    {
        currentSpeed = moveSpeed;
        speedTimer = TIMER_START;
        speedChange = false;
    }

    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal");
        float moveAmount = Input.GetAxis("Vertical");
        transform.Rotate(0, 0, -steerAmount * steerSpeed * Time.deltaTime);
        transform.Translate(0, currentSpeed * moveAmount * Time.deltaTime, 0);
        if (speedChange)
        {
            if (speedTimer > 0)
            {
                speedTimer -= Time.deltaTime;
            }
            else
            {
                Debug.Log("speedTimer = 0");
                currentSpeed = moveSpeed;
                speedTimer = TIMER_START;
                speedChange = false;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Boost"))
        {
            Debug.Log("Boost!");
            currentSpeed = boostSpeed;
            speedTimer = TIMER_START;
            speedChange = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        currentSpeed = slowSpeed;
        speedTimer = TIMER_START;
        speedChange = true;
    }
}
