using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Row : MonoBehaviour
{
    public Tile[] tiles { get; private set; }
    public string word
    {
        get
        {
            string word = "";

            for(int i = 0; i < tiles.Length; i++)
            {
                word += tiles[i].letter;
            }
            return word;
        }
    }
    private void Awake()
    {
        tiles = GetComponentsInChildren<Tile>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
