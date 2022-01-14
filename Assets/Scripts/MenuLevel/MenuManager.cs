using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using DG.Tweening;

public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject menuPaneli;
    

    void Start()
    {
        
    }
    private void Awake()
    {
       
    }
    public void HangiOyunAcilsin(string hangiOyun)
    {
        //if (PlayerPrefs.GetInt("sesDurumu") == 1)
        //{
        //    menuses.PlayOneShot(butonClick);


        //}

        PlayerPrefs.SetString("hangiOyun", hangiOyun);
        //adMobManager.bannerView.Destroy();
        SceneManager.LoadScene("GameLevel");
    }
    public void SayilarGame()
    {
        SceneManager.LoadScene("SayilarLevel");
    } public void RenklerGame()
    {
        SceneManager.LoadScene("RenklerLevel");
    } public void HayvanlarGame()
    {
        SceneManager.LoadScene("HayvanlarLevel");
    } public void PuzzleGame()
    {
        SceneManager.LoadScene("PuzzleLevel");
    } 


    public void Ayarlar()
    {
       

    }

    public void Hakkinda()
    {
       
    }
}
