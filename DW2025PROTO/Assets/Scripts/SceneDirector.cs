using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneDirector : MonoBehaviour
{

    string[] terrors = {"test", "test2"};

    public int terrorSelectedNum;

    string terrorSelected;

    // Start is called before the first frame update
    void Start()
    {
        terrorSelected = terrors[terrorSelectedNum];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
