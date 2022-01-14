using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bitir : MonoBehaviour
{
    int toplamhayvan = 3;
    int ilkhayvan = 0;

    //3 eşleşme olunca oyunu bitir
 public void levelSon()
    {
        ilkhayvan++;
        if (ilkhayvan==toplamhayvan)
        {
            
            Debug.Log("Oyun Bittti");
        }
    }
}
