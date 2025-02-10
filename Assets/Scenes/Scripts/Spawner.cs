using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    public float cooldown = 1f;

    public PhaseData[] phases;

    private int index;

    float timeStamp;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        /* Deve prendere la data all'indice corrente.
        * Controllare che non sia stata superata la threshold. (Se sì, passa alla fase successiva. index +1)
        * Calcola il cooldown prendendo un numero random tra min e max della fase corrente.
        * Quando finisce il cooldown, istanzia l'oggetto e ricalcola il nuovo cooldown.
        */

        PhaseData phase = phases[index];

        if (Time.time >= phase.timeThreshold && index < phases.Lenght -1)
        {
            index++;
            phase = phases[index];
        }

        if (Time.time - timeStamp >= cooldown)
        {
            Instantiate(objectToSpawn, transform.position, transform.rotation);
            timeStamp = Time.time;
            cooldown = Random.Range(phase.minRange, phase.maxRange);
        }
    }
}
