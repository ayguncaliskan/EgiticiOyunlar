using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TasiKolaySon : MonoBehaviour
{
    // Start is called before the first frame update
    int toplamhayvan = 3;
    int ilkhayvan = 0;

    //3 eşleşme olunca oyunu bitir
    public void levelSon()
    {
        ilkhayvan++;
        if (ilkhayvan == toplamhayvan)
        {

            Debug.Log("Oyun Bittti");
        }
    }
}
