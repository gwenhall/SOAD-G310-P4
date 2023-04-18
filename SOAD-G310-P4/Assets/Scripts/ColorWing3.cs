using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorWing3 : MonoBehaviour
{
    public SpriteRenderer Wing3;
    void Start()
    {
       Wing3 = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Wing3.color = Random.ColorHSV();
        print("Changed");
    }
}
