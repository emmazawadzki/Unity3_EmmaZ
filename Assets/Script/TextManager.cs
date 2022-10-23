using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textPerso;
    [SerializeField] private TextMeshProUGUI textTexte;
    [SerializeField] private Personnages perso;

    private void Start(){
        textPerso.text = perso.nom;
        textTexte.text = perso.texte[0];
    }
}
