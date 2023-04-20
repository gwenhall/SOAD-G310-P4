using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class HornSwitcher : MonoBehaviour
{

    public Sprite[] horns;

    SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
       spriteRenderer = GetComponent<SpriteRenderer>();
    }

   public void SwitchToSprite(int index)
   {
          spriteRenderer.sprite = horns[index + 1];
   }
}
