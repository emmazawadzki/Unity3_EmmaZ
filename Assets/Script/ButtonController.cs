using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    [SerializeField] private Button Bouton;
    [SerializeField] private TextMeshProUGUI textPerso;
    [SerializeField] private TextMeshProUGUI textTexte;
    [SerializeField] private Personnages perso1;
    [SerializeField] private Personnages perso2;
    int CountButton=1;
    int CountPerso1=1;
    int CountPerso2=0;



    public void GererClic(){
        Debug.Log("Vous avez cliqué sur le bouton!");
        Debug.Log("CountButton: " + CountButton);

        if(CountButton==1 || CountButton==2 || CountButton==5){
            textPerso.text = perso1.nom;
            textTexte.text = perso1.texte[CountPerso1];
            CountPerso1+=1;
        }
        else if(CountButton==3 || CountButton==4){
            textPerso.text = perso2.nom;
            textTexte.text = perso2.texte[CountPerso2];
            CountPerso2+=1;
        }
        else{
            textPerso.text = "";
            textTexte.text = "";
        }
        
        CountButton+=1;
    }

}
