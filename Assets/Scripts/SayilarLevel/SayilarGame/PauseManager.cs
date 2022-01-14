using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseManager : MonoBehaviour
{
    [SerializeField]
    private GameObject pausePaneli;
    [SerializeField]
    private GameObject sonuclarObje;
  
    
    private void OnEnable()
    {
      
      
        Time.timeScale = 0f;
        sonuclarObje.SetActive(false);
    }
    private void OnDisable()
    {
        Time.timeScale = 1f;
        
    }
    public void Oyunadon()
    {
        
        pausePaneli.SetActive(false);
        sonuclarObje.SetActive(true);


    }
    
    public void MenuyeDon()
    {
        SceneManager.LoadScene("SayilarLevel");
        
    }
}
