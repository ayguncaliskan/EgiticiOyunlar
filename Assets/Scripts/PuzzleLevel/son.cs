using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class son : MonoBehaviour
{
    // Start is called before the first frame update
    int parca = 0;
    int toplamParca = 9;
    void Start()
    {
        
    }
    //her çagrıldıgında sayı artacak
    public void sayi_arttir()
    {
        parca++;
        if (parca==toplamParca)
        {
            Debug.Log("Oyun Bitti");
        }
    }
    public void GeriDon()
    {
        SceneManager.LoadScene("PuzzleLevel");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
