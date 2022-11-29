using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class HeroObject : MonoBehaviour
{
    public Hero hero;
    SpriteRenderer spriteRenderer;
    Image image;

    private void Start()
    {
       // spriteRenderer = GetComponent<SpriteRenderer>();
        image = GetComponent<Image>();
    }

    void Update()
    {
        //spriteRenderer.sprite = hero.image;
        image.sprite = hero.image;
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
