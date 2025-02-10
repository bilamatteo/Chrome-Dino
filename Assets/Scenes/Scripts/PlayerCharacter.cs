using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerCharacter : MonoBehaviour
{
    public float maxSpeed = 8f;
    public float sprint = 1f;
    public Vector2 direction;

    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        float x;
        float y;

        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        direction = new Vector2(x, y);
        Debug.Log(direction);

        transform.position += maxSpeed * Time.deltaTime * (Vector3)direction;

    }
    void Move(float speed)
    {
        transform.position = speed * Vector3.right * Time.deltaTime;
    }
}