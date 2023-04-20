using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorHorn1 : MonoBehaviour
{
    public SpriteRenderer Horn1;
    void Start()
    {
       Horn1 = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Horn1.color = Random.ColorHSV();
        print("Changed");
    }
}
