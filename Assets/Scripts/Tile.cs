using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    private int _xCoordinate;
    private int _yCoordinate;
    public int _XCoordinate
    {
        get { return _xCoordinate; }
        set { _xCoordinate = value; }
    }
    public int _YCoordinate
    {
        get { return _yCoordinate; }
        set { _yCoordinate = value; }
    }
    private Color _oldColor;

    private void Start()
    {

    }
    private void OnMouseEnter()
    {
        _oldColor = GetComponent<SpriteRenderer>().color;
        GetComponent<SpriteRenderer>().color = new Color(_oldColor.r, _oldColor.g, _oldColor.b, 0.25f);
    }

    private void OnMouseExit()
    {
        GetComponent<SpriteRenderer>().color = _oldColor;
    }
}
