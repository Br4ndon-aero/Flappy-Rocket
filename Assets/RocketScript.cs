using UnityEngine;

public class RocketScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool rocketIsAlive = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && rocketIsAlive == true)
        {
            myRigidbody.linearVelocity = Vector2.up * flapStrength;
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Astroid")
        {
            FindFirstObjectByType<LogicScript>().gameOver();
        }
        logic.gameOver();
        rocketIsAlive = false;
    }
}

