using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    private Color oldColor;
    private void OnMouseEnter()
    {
        oldColor = GetComponent<SpriteRenderer>().color;
        GetComponent<SpriteRenderer>().color = new Color(oldColor.r, oldColor.g, oldColor.b, 0.25f);
    }

    private void OnMouseExit()
    {
        GetComponent<SpriteRenderer>().color = oldColor;
    }
}
