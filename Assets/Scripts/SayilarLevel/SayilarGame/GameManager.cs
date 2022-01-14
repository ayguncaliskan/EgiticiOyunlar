using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject baslaImage;
    [SerializeField]
    private GameObject dogruImage, yanlisImage;
    
    AudioSource gameses;
    [SerializeField]
    private Text soruText, birinciSonucText, ikinciSonucText, ucuncuSonucText;
    [SerializeField]
    private GameObject sonucPaneli;
    [SerializeField]
    private Text dogruAdetText, yanlisAdetText, puanText;
    [SerializeField]
    private GameObject pausePaneli;
    string hangiOyun;
    [SerializeField]
    private GameObject sonuclarObje, zamanObje, dogruYanlisObje, playerObje, puanObje,pauseobje;
    int birinciCarpan;
    int ikinciCarpan;

    int dogruSonuc;
    int birinciYanlisSonuc;
    int ikinciYanlisSonuc;

    public int dogruAdet, yanlisAdet, toplamPuan;
    int kalanHak;
    KalanHaklarManager kalanHaklarManager;
    PlayerManager playerManager;
    

    void Start()
    {
        gameses = GetComponent<AudioSource>();
        kalanHak = 3;
        kalanHaklarManager = Object.FindObjectOfType<KalanHaklarManager>();
        kalanHaklarManager.KalanHaklariKontrolEt(kalanHak);
        dogruAdet = 0;
        yanlisAdet = 0;
        toplamPuan = 0;

        dogruImage.GetComponent<RectTransform>().localScale = Vector3.zero;
        yanlisImage.GetComponent<RectTransform>().localScale = Vector3.zero;


        if (PlayerPrefs.HasKey("hangiOyun"))
        {
            hangiOyun = PlayerPrefs.GetString("hangiOyun");
        }
        //if (PlayerPrefs.GetInt("sesDurumu") == 1)
        //{
        //    gameses.mute = false;

        //}
        //else
        //{
            gameses.mute = true;
        //}
        StartCoroutine(baslaYaziRoutine());
        

    }

    IEnumerator baslaYaziRoutine()
    {
        baslaImage.GetComponent<RectTransform>().DOScale(1.3f, 0.5f);
        yield return new WaitForSeconds(0.6f);
        baslaImage.GetComponent<RectTransform>().DOScale(0f, 0.5f).SetEase(Ease.InBack);
        baslaImage.GetComponent<CanvasGroup>().DOFade(0f, 1f);
        yield return new WaitForSeconds(0.6f);

        OyunaBasla();


    }
    void OyunaBasla()
    {
        playerManager.rotaDegissinmi = true;
        SoruyuYazdir();


    }
    private void Awake()
    {
        
        playerManager = Object.FindObjectOfType<PlayerManager>();
        
    }
    void BirinciCarpaniAyarla()
    {
        switch (hangiOyun)
        {
            
            case "carp":
                birinciCarpan = Random.Range(2, 11);
                break;
            case "topla":
                birinciCarpan = Random.Range(10, 90);
                break;
            case "bol":
                birinciCarpan = Random.Range(1, 31);
                break;
            case "cikar":
                birinciCarpan = Random.Range(2, 11);
                break;

        }


    }
    
        


    
    void SoruyuYazdir()
    {
        if (hangiOyun == "carp")
        {
            BirinciCarpaniAyarla();

            ikinciCarpan = Random.Range(2, 11);

            int rastgeleDeger = Random.Range(1, 100);

            if (rastgeleDeger <= 50)
            {
                soruText.text = birinciCarpan.ToString() + "x" + ikinciCarpan.ToString();
            }
            else
            {
                soruText.text = ikinciCarpan.ToString() + "x" + birinciCarpan.ToString();
            }

            dogruSonuc = birinciCarpan * ikinciCarpan;

            SonuclariYazdir();
        }
        else if (hangiOyun == "topla")
        {
            BirinciCarpaniAyarla();
            ikinciCarpan = Random.Range(2, 90);
            int rastgeleDeger = Random.Range(1, 100);
            if (rastgeleDeger <= 50)
            {
                soruText.text = birinciCarpan.ToString() + "+" + ikinciCarpan.ToString();
            }
            else
            {
                soruText.text = ikinciCarpan.ToString() + "+" + birinciCarpan.ToString();
            }

            dogruSonuc = birinciCarpan + ikinciCarpan;

            SonuclariYazdir();
        }
        else if (hangiOyun == "bol")
        {
            birinciCarpan = Random.Range(1, 100);
            ikinciCarpan = Random.Range(1, 100);
            int rastgeleDeger = Random.Range(1, 200);
            while (birinciCarpan % ikinciCarpan != 0)
            {
                birinciCarpan = Random.Range(1, 100);
                ikinciCarpan = Random.Range(1, 100);
            }
            
            
                soruText.text = birinciCarpan.ToString() + "/" + ikinciCarpan.ToString();
            

            dogruSonuc = birinciCarpan / ikinciCarpan;

            SonuclariYazdir();
        }
        else if (hangiOyun == "cikar")
        {
            birinciCarpan = Random.Range(0, 100);
            ikinciCarpan = Random.Range(0, 100);

            while (birinciCarpan <= ikinciCarpan)
            {
                birinciCarpan = Random.Range(0, 100);
                ikinciCarpan = Random.Range(0, 100);
            }
            int rastgeleDeger = Random.Range(1, 100);
            //if (rastgeleDeger <= 50)
            //{
                soruText.text = birinciCarpan.ToString() + "-" + ikinciCarpan.ToString();
            //}
            ////else
            ////{
            ////    soruText.text = ikinciCarpan.ToString() + "-" + birinciCarpan.ToString();
            ////}

            dogruSonuc = birinciCarpan - ikinciCarpan;

            SonuclariYazdir();
        }
       
    }
    void SonuclariYazdir()
    {
        if (hangiOyun == "carp")
        {
            birinciYanlisSonuc = dogruSonuc + Random.Range(2, 10);

            if (dogruSonuc > 10)
            {
                ikinciYanlisSonuc = dogruSonuc - Random.Range(2, 8);
            }
            else
            {
                ikinciYanlisSonuc = Mathf.Abs(dogruSonuc - Random.Range(1, 5));
            }


            int rastgeleDeger = Random.Range(1, 100);


            if (rastgeleDeger <= 33)
            {
                birinciSonucText.text = dogruSonuc.ToString();
                ikinciSonucText.text = birinciYanlisSonuc.ToString();
                ucuncuSonucText.text = ikinciYanlisSonuc.ToString();

            }
            else if (rastgeleDeger <= 66)
            {
                ikinciSonucText.text = dogruSonuc.ToString();
                birinciSonucText.text = birinciYanlisSonuc.ToString();
                ucuncuSonucText.text = ikinciYanlisSonuc.ToString();
            }
            else
            {
                ucuncuSonucText.text = dogruSonuc.ToString();
                ikinciSonucText.text = birinciYanlisSonuc.ToString();
                birinciSonucText.text = ikinciYanlisSonuc.ToString();
            }
        }
        else if (hangiOyun == "bol")
        {
            birinciYanlisSonuc = dogruSonuc + Random.Range(2, 10);

            if (dogruSonuc > 50)
            {
                ikinciYanlisSonuc = dogruSonuc - Random.Range(2, 8);
            }
            else
            {
                ikinciYanlisSonuc = Mathf.Abs(dogruSonuc - Random.Range(1, 5));
            }



            int rastgeleDeger = Random.Range(1, 300);


            if (rastgeleDeger <= 50)
            {
                birinciSonucText.text = dogruSonuc.ToString();
                ikinciSonucText.text = birinciYanlisSonuc.ToString();
                ucuncuSonucText.text = ikinciYanlisSonuc.ToString();

            }
            else if (rastgeleDeger <= 100)
            {
                ikinciSonucText.text = dogruSonuc.ToString();
                birinciSonucText.text = birinciYanlisSonuc.ToString();
                ucuncuSonucText.text = ikinciYanlisSonuc.ToString();
            }
            else
            {
                ucuncuSonucText.text = dogruSonuc.ToString();
                ikinciSonucText.text = birinciYanlisSonuc.ToString();
                birinciSonucText.text = ikinciYanlisSonuc.ToString();
            }
        }
        else if (hangiOyun == "topla")
        {
            birinciYanlisSonuc = dogruSonuc + Random.Range(2, 10);

            if (dogruSonuc > 100)
            {
                ikinciYanlisSonuc = dogruSonuc - Random.Range(2, 8);
            }
            else
            {
                ikinciYanlisSonuc = Mathf.Abs(dogruSonuc - Random.Range(1, 5));
            }


            int rastgeleDeger = Random.Range(1, 300);


            if (rastgeleDeger <= 100)
            {
                birinciSonucText.text = dogruSonuc.ToString();
                ikinciSonucText.text = birinciYanlisSonuc.ToString();
                ucuncuSonucText.text = ikinciYanlisSonuc.ToString();

            }
            else if (rastgeleDeger <= 200)
            {
                ikinciSonucText.text = dogruSonuc.ToString();
                birinciSonucText.text = birinciYanlisSonuc.ToString();
                ucuncuSonucText.text = ikinciYanlisSonuc.ToString();
            }
            else
            {
                ucuncuSonucText.text = dogruSonuc.ToString();
                ikinciSonucText.text = birinciYanlisSonuc.ToString();
                birinciSonucText.text = ikinciYanlisSonuc.ToString();
            }
        }
        else if (hangiOyun == "cikar")
        {
            birinciYanlisSonuc = dogruSonuc + Random.Range(2, 10);

            if (dogruSonuc > 10)
            {
                ikinciYanlisSonuc = dogruSonuc - Random.Range(2, 8);
            }
            else
            {
                ikinciYanlisSonuc = Mathf.Abs(dogruSonuc - Random.Range(1, 5));
            }


            int rastgeleDeger = Random.Range(1, 100);


            if (rastgeleDeger <= 33)
            {
                birinciSonucText.text = dogruSonuc.ToString();
                ikinciSonucText.text = birinciYanlisSonuc.ToString();
                ucuncuSonucText.text = ikinciYanlisSonuc.ToString();

            }
            else if (rastgeleDeger <= 66)
            {
                ikinciSonucText.text = dogruSonuc.ToString();
                birinciSonucText.text = birinciYanlisSonuc.ToString();
                ucuncuSonucText.text = ikinciYanlisSonuc.ToString();
            }
            else
            {
                ucuncuSonucText.text = dogruSonuc.ToString();
                ikinciSonucText.text = birinciYanlisSonuc.ToString();
                birinciSonucText.text = ikinciYanlisSonuc.ToString();
            }

        }
    }

    public void SonucuKontrolEt(int textSonucu)
    {

        dogruImage.GetComponent<RectTransform>().localScale = Vector3.zero;
        yanlisImage.GetComponent<RectTransform>().localScale = Vector3.zero;

        if (textSonucu == dogruSonuc)
        {
            dogruAdet++;
            toplamPuan += 20;
            dogruImage.GetComponent<RectTransform>().DOScale(1, .1f);


        }
        else
        {
            yanlisAdet++;
            toplamPuan -= 20;
            kalanHak--;
            kalanHaklarManager.KalanHaklariKontrolEt(kalanHak);
            kalanhakbitti();
            
            yanlisImage.GetComponent<RectTransform>().DOScale(1, .1f);
        }

        dogruAdetText.text = dogruAdet.ToString() + " DOĞRU";
        yanlisAdetText.text = yanlisAdet.ToString() + " YANLIŞ";
        puanText.text = toplamPuan.ToString() + " PUAN";


        SoruyuYazdir();
       
    }

    
    public void pausePaneliniAc()
    {
        pausePaneli.SetActive(true);
    }

    void kalanhakbitti()
    {
        kalanHaklarManager.KalanHaklariKontrolEt(kalanHak);
        if (kalanHak <= 0)
        {
            
            sonucPaneli.SetActive(true);
            sonuclarObje.SetActive(false);
            zamanObje.SetActive(false);
            dogruYanlisObje.SetActive(false);
            playerObje.SetActive(false);
            puanObje.SetActive(false);
            pauseobje.SetActive(false);

        }
        
    }
    }
//reklam.RequestRewardedAd();