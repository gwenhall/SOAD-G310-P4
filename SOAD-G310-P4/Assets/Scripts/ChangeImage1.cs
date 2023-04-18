using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeImage1 : MonoBehaviour
{
    public Image original;
    public Sprite newSprite;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NewImage()
    {
        original.sprite = newSprite;
    }
}
