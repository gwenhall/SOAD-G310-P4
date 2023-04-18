using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorWings1 : MonoBehaviour
{
    public SpriteRenderer Wing1;
    void Start()
    {
       Wing1 = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Wing1.color = Random.ColorHSV();
        print("Changed");
    }
}
