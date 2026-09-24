using Unity.VisualScripting;
using UnityEngine;

public class SatSpawnScript : MonoBehaviour
{
    public GameObject satellite;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 10;

    public float minimumVerticalDistance = 3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnSatellite();
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
            spawnSatellite();
            timer = 0;
        }
        
    }

    void spawnSatellite()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        float satelliteY;

        do
        {
            satelliteY = Random.Range(lowestPoint, highestPoint);
        } while (Mathf.Abs(satelliteY - AstroidSpawnScript.lastAstroidY) < minimumVerticalDistance);

        Instantiate(satellite, new Vector3(transform.position.x, satelliteY, 0), transform.rotation);

    }
}
