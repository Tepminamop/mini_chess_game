using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField] private int _width, _height;
    [SerializeField] private Tile _tile1;
    [SerializeField] private Tile _tile2;
    [SerializeField] private Transform _cam;
    private void Start()
    {
        GenerateGrid();
    }

    private void GenerateGrid()
    {
        for (int x = 0; x < _width; x++)
        {
            for (int y = 0; y < _height; y++)
            {
                bool isOffset = (x % 2 == 0 && y % 2 != 0) || (x % 2 != 0 && y % 2 == 0);
                var _spawnedTile = isOffset == true ? Instantiate(_tile1, new Vector3(x, y), Quaternion.identity) : Instantiate(_tile2, new Vector3(x, y), Quaternion.identity);
                _spawnedTile.name = $"Title {x} {y}";
            }
        }

        _cam.transform.position = new Vector3((float)_width / 2 - 0.5f, (float)_height / 2 - 0.5f, -10);
    }
}
