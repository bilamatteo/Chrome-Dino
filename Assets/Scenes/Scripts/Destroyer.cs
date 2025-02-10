using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject collideObject = collision.gameObject;

        Destroy(collideObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        1) L'aumento della velocità degli ostacoli è esponenziale sulla base dell'incrementare del punteggio.
        2) L'altezza degli ostacoli è differente.
        3) Il distanziamento degli ostacoli è misurato 
        */
    }
}
