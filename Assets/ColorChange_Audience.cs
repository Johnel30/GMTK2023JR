using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange_Audience : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color[] colors = new Color[3];
    public float changeInterval = 5f;

    private int currentIndex = 0;

    private void Start()
    {
        
        StartCoroutine(ChangeColorCoroutine());
        
    }

    private IEnumerator ChangeColorCoroutine()
    {
        while (true)
        {
            // Change the sprite color
            spriteRenderer.color = colors[currentIndex];

            // Increment the index to move to the next color
            currentIndex = (currentIndex + 1) % colors.Length;

            yield return new WaitForSeconds(changeInterval);
        }
    }
}
