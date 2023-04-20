using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorBug : MonoBehaviour
{
    public SpriteRenderer bug;
    void Start()
    {
       bug = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        bug.color = Random.ColorHSV();
        print("Changed");
    }
}
