using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moeda : MonoBehaviour
{
    public int velocidadeGiro = 50;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(eulers:Vector3.up * velocidadeGiro * Time.deltaTime, relativeTo:Space.World);
    }
}
