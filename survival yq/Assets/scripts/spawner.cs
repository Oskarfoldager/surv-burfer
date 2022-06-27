using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject playerr;
    public GameObject enemyPrefab;
    public float period = 20f;
    private float nextactiontime = 0;

    // Start is called before the first frame update
    void Update()
    {

        if (Time.time > nextactiontime)
        {
            Debug.Log("Attempting to spawn enemy");
            GameObject thisproj = Instantiate(enemyPrefab, transform.position, transform.rotation);
            nextactiontime += period;
        }


    }
}
