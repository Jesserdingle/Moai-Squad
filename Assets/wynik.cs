using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class wynik : MonoBehaviour
{
    public Text wyniktext;
    private int WynikNumer;
    private int iloscChrupek = 0;
    
    void Start()
    {
        WynikNumer = 0;
        iloscChrupek = GameObject.FindGameObjectsWithTag("colect").Length;
        wyniktext.text = $"Scooby Snacki:0/{iloscChrupek}";
    }

    private void OnTriggerEnter2D(Collider2D Scooby)
    {
        if (Scooby.tag == "colect")
        {
            Destroy(Scooby.gameObject);
            WynikNumer = WynikNumer + 1;
            wyniktext.text = $"Scooby Snacki:{WynikNumer}/{iloscChrupek}";  
        }
    }
}

