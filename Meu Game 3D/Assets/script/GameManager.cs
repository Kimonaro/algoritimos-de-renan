using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI ContadorMoedas, MsgFim;
    public int restantes;
    
     
    // Start is called before the first frame update
    void Start()
    {
        restantes = FindObjectsOfType<moeda>().Length;

        ContadorMoedas.text = $"Moedas restantes:{restantes}";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
