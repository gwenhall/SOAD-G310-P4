using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorHorn2 : MonoBehaviour
{
    public SpriteRenderer Horn2;
    void Start()
    {
       Horn2 = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Horn2.color = Random.ColorHSV();
        print("Changed");
    }
}
