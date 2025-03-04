using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnInteract : MonoBehaviour
{
    public Material on;
    public Material off;
    MeshRenderer mr;
    float onTimer;
    void Start()
    {
        mr = gameObject.GetComponent<MeshRenderer>();   
    }

    // Update is called once per frame
    void Update()
    {
        onTimer -= Time.deltaTime;
        if(onTimer <= 0) { mr.material = off; }
    }
    public void Interact()
    {
        onTimer = 1;
        mr.material = on;
    }
}
