using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor-Wings-1 : MonoBehaviour
{
    public SpriteRenderer Wing-1;
    void Start()
    {
       Wing-1 = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Wing-1.color = Random.ColorHSV();
        print("Changed");
    }
}
