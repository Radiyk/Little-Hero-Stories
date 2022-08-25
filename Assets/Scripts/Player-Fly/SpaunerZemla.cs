using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaunerZemla : MonoBehaviour
{
    public GameObject[] VariantZemla;

    private float timeBtwSpawn;
    public float startTimeBtwSpawn;
    void Update()
    {
        if (timeBtwSpawn <= 0)
        {
            int rand = Random.Range(0, VariantZemla.Length);
            Instantiate(VariantZemla[rand], transform.position, Quaternion.identity);
            timeBtwSpawn = startTimeBtwSpawn;
        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
    }
}
