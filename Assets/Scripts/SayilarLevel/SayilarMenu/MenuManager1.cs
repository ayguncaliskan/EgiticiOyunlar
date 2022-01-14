using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;
public class MenuManager1 : MonoBehaviour
{
    [SerializeField]
    private GameObject menuPaneli;
    //[SerializeField]
    //private GameObject hakkindaPaneli;
  

   AudioSource menuses;

    [SerializeField]
    private AudioClip butonClick;
    

    [SerializeField]
    private GameObject sesPaneli;

    bool sesPaneliAcikmi;
   
    void Start()
    {
      
   
        menuses = GetComponent<AudioSource>();
        
        sesPaneliAcikmi = false;
        sesPaneli.GetComponent<RectTransform>().localPosition = new Vector3(0, -177, 0);
        menuPaneli.GetComponent<CanvasGroup>().DOFade(1, 1f);
        menuPaneli.GetComponent<RectTransform>().DOScale(1, 1f).SetEase(Ease.OutBack);
    }
    private void Awake()
    {
       
    }
    public void HangiOyunAcilsin(string hangiOyun)
    {
        if (PlayerPrefs.GetInt("sesDurumu") == 1)
        {
            menuses.PlayOneShot(butonClick);
            

        }

        PlayerPrefs.SetString("hangiOyun", hangiOyun);
      
        SceneManager.LoadScene("SayilarGameLevel");
    }

   public void geridon()
    {
        SceneManager.LoadScene("MenuLevel");
    }

    public void Ayarlar()
    {
        if (PlayerPrefs.GetInt("sesDurumu") == 1)
        {
            menuses.mute = false;
            menuses.PlayOneShot(butonClick);


        }
        else
        {
            menuses.mute = true;
        }

        if (!sesPaneliAcikmi)
        {
            sesPaneli.GetComponent<RectTransform>().DOLocalMoveY(-177, 0.5f);
            sesPaneliAcikmi = true;
        }
        else
        {
            sesPaneli.GetComponent<RectTransform>().DOLocalMoveY(-177, 0.5f);
            sesPaneliAcikmi = false;
        }

    }

    //public void Hakkinda()
    //{

    //    hakkindaPaneli.SetActive(true);
    //}





}
