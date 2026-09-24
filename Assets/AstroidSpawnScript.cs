using Unity.VisualScripting;
using UnityEngine;

public class AstroidSpawnScript : MonoBehaviour
{
    public GameObject astroid;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 10;

    public static float lastAstroidY;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnAstroid();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnAstroid();
            timer = 0;
        }
        
    }

    void spawnAstroid()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        lastAstroidY = Random.Range(lowestPoint, highestPoint);

        Instantiate(astroid, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);

    }
}
