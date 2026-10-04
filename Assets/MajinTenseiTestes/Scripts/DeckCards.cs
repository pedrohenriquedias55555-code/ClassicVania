using UnityEngine;
using System.Collections.Generic;

public class DeckCards : MonoBehaviour
{
    [SerializeField] List<Sprite> cards = new List<Sprite>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Sprite[] loadCards = Resources.LoadAll<Sprite>("Sprites");

        cards.AddRange(loadCards);
        
        Debug.Log("Sprites loaded " + cards.Count);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
