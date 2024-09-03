using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI ContadorMoedas, MsgFim;
    public int restantes;
    private AudioSource source;
    public AudioClip somMoeda, somVitoria;

    // Start is called before the first frame update
    void Start()

    {
        restantes = FindObjectsOfType<moeda>().Length;
        TryGetComponent(out source);
        ContadorMoedas.text = $"Moedas restantes:{restantes}";
    }

    public void SubtrairMoedas(int valor)
    
    {
        restantes = restantes - valor;
        source.PlayOneShot(somMoeda);
        ContadorMoedas.text = $"Moedas restantes:{restantes}";
        if (restantes <= 0)
        {
            MsgFim.text = "fim :D";
            source.PlayOneShot(somVitoria);
        }
    }

// Update is called once per frame
    void Update()
    {
        
    }
}
