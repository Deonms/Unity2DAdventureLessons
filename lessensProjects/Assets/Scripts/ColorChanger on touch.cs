using System;
using UnityEngine;

public class ColorChangerontouch : MonoBehaviour
{
    private SpriteRenderer sr;
    [SerializeField] private string _colorTochangeTo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player") //check of er een speler erop komt zo ja dan word playercount +1 gedaan
        {
            if (ColorUtility.TryParseHtmlString(_colorTochangeTo, out Color newColor))
            {
                SpriteRenderer playerSr = collision.gameObject.GetComponent<SpriteRenderer>();

                if (playerSr != null)
                {
                    playerSr.color = newColor;
                }
                else
                {
                    Debug.LogWarning("Player heeft geen SpriteRenderer op de zelfde GameObject.");
                }

            }
            else
            {
                Console.WriteLine("Invalid hex kleur: " + _colorTochangeTo);
            }
        }
    }
}
