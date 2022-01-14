using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuzzleManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GeriDon()
    {
        SceneManager.LoadScene("MenuLevel");
    }
    public void KolayPuzzle()
    {
        SceneManager.LoadScene("KolayPuzzle");
    }
    public void OrtaPuzzle()
    {
        SceneManager.LoadScene("OrtaPuzzle");
    }
    public void ZorPuzzle()
    {
        SceneManager.LoadScene("ZorPuzzle");
    }
}
