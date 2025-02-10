using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    public float cooldown = 1f;

    float timeStamp;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - timeStamp >= cooldown)
        {
            Instantiate(objectToSpawn, transform.position, transform.rotation);
            timeStamp = Time.time;
        }
    }
}
