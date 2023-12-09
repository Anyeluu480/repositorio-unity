using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
{

    }

    // Update is called once per frame
    void Update()
    {
    // Rotar el objeto alrededor del eje Z a una velocidad de 45 grados por segundo
    target.Rotate(0, 0, 45 * Time.deltaTime);
}

    }
}
