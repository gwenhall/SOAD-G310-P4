using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorFin : MonoBehaviour
{
    public SpriteRenderer fin;
    void Start()
    {
       fin = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        fin.color = Random.ColorHSV();
        print("Changed");
    }
}
