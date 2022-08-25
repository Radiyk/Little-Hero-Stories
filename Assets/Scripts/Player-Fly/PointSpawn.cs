using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointSpawn : MonoBehaviour
{
    public GameObject zemla;
    void Start()
    {
        Instantiate(zemla, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
