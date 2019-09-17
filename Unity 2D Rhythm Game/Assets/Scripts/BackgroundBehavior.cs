using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundBehavior : MonoBehaviour
{
    public GameObject gameBackground;
    private SpriteRenderer gameBackgoundSpriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        gameBackgoundSpriteRenderer = gameBackground.GetComponent<SpriteRenderer>();
        StartCoroutine(FadeOut(gameBackgoundSpriteRenderer,0.005f));
    }

    IEnumerator FadeOut (SpriteRenderer spriteRenderer, float amount)
    {
        Color color = spriteRenderer.color;
        while(color.a > 0.0f)
        {
            color.a -= amount;
            spriteRenderer.color = color;
            yield return new WaitForSeconds(amount);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
