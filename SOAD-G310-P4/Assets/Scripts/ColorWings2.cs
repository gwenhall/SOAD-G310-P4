using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorWings2 : MonoBehaviour
{
    public SpriteRenderer Wing2;
    void Start()
    {
       Wing2 = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Wing2.color = Random.ColorHSV();
        print("Changed");
    }
}
