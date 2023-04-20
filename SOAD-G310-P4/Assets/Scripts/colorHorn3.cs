using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorHorn3 : MonoBehaviour
{
    public SpriteRenderer Horn3;
    void Start()
    {
       Horn3 = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Horn3.color = Random.ColorHSV();
        print("Changed");
    }
}
