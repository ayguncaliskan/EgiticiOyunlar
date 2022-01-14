using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuzzleKolayManager : MonoBehaviour {

    public GameObject resim1, resim2, resim3, resim4, resim5, resim1Black, resim2Black, resim3Black, resim4Black, resim5Black,tekraroynabtn,menuyedonbtn,sontext;


    Vector3 ilkresim1Position, ilkresim2Position, ilkresim3Position, ilkresim4Position, ilkresim5Position;
    //resimler eslesmeleri kontrol etmek için
    bool resim1Bool, resim2Bool, resim3Bool, resim4Bool, resim5Bool = false;

    public AudioSource source;
    public AudioClip dogru;
    public AudioClip yanlis;
  



  
    //başlangıçta tüm pozisyonları resimin kendi pozisyonlarına eşitliyoruz
    void Start()
    {
        ilkresim1Position = resim1.transform.position;
        ilkresim2Position = resim2.transform.position;
        ilkresim3Position = resim3.transform.position;
        ilkresim4Position = resim4.transform.position;
        ilkresim5Position = resim5.transform.position;
        tekraroynabtn.SetActive(false);
        menuyedonbtn.SetActive(false);
        sontext.SetActive(false);
    }


 

    //farenin ekrandaki konumunu alıyoruz
    public void Surukleresim1()
    {

        
        resim1.transform.position = Input.mousePosition;

    }


    public void Surukleresim2()
    {

       
        resim2.transform.position = Input.mousePosition;

    }

    public void Surukleresim3()
    {

       
        resim3.transform.position = Input.mousePosition;

    }
 
    public void Surukleresim4()
    {

       
        resim4.transform.position = Input.mousePosition;

    }

    public void Surukleresim5()
    {
       
        resim5.transform.position = Input.mousePosition;
        
    }





    


    public void Birakresim1()
    {
        //aradaki mesafe hesaplanır 50den küçükse eşleştir ve dogru sesini çal değilse ilk haline geri döndür
        float distance = Vector3.Distance(resim1.transform.position, resim1Black.transform.position);
        if (distance < 50)
        {
            resim1.transform.position = resim1Black.transform.position;
          
            resim1Bool = true;
            source.clip = dogru;
            source.Play();

        }
        else

        {
            resim1.transform.position = ilkresim1Position;
            source.clip = yanlis;
            source.Play();
        }




    }

    public void Birakresim2()
    {

        float distance = Vector3.Distance(resim2.transform.position, resim2Black.transform.position);
        if (distance < 50)
        {
            resim2.transform.position = resim2Black.transform.position;
          
            resim2Bool = true;
            source.clip = dogru;
            source.Play();
        }
        else
        {
            resim2.transform.position = ilkresim2Position;
           source.clip = yanlis;
            source.Play();
        }

    }

    public void Birakresim3()
    {

        float distance = Vector3.Distance(resim3.transform.position, resim3Black.transform.position);
        if (distance < 50)
        {
         
            resim3.transform.position = resim3Black.transform.position;
        
            resim3Bool = true;
            source.clip = dogru;
            source.Play();
        }
        else
        {
            resim3.transform.position = ilkresim3Position;
            source.clip = yanlis;
            source.Play();
        }

    }


    public void Birakresim4()
    {

        float distance = Vector3.Distance(resim4.transform.position, resim4Black.transform.position);
        if (distance < 50)
        {
          
            resim4.transform.position = resim4Black.transform.position;
            resim4.transform.localScale = resim4Black.transform.localScale;
           
            resim4Bool = true;
            source.clip = dogru;
            source.Play();
        }
        else
        {
            resim4.transform.position = ilkresim4Position;
            source.clip = yanlis;
            source.Play();
        }



    }
    public void Birakresim5()
    {

        float distance = Vector3.Distance(resim5.transform.position, resim5Black.transform.position);
        if (distance < 50)
        {
            
            resim5.transform.position = resim5Black.transform.position;
           
            resim5Bool = true;
            source.clip = dogru;
            source.Play();
        }
        else
        {
            resim5.transform.position = ilkresim5Position;
            source.clip = yanlis;
            source.Play();
        }


        
    }
    public void tekrarOyna()
    {
        SceneManager.LoadScene("KolayPuzzle");
    }  
    public void menuyedon()
    {
        SceneManager.LoadScene("PuzzleLevel");
    }
    //tüm resimler dogru ise objelerini set activelerini kapat diğer elemanları aç
    public void oyunubitir()
    {
        if (resim1Bool && resim2Bool && resim3Bool && resim4Bool && resim5Bool == true)
        {
            resim1.SetActive(false);
            resim1Black.SetActive(false); 
            resim2.SetActive(false);
            resim2Black.SetActive(false);
            resim3.SetActive(false);
            resim3Black.SetActive(false); 
            resim4.SetActive(false);
            resim4Black.SetActive(false); 
            resim5.SetActive(false);
            resim5Black.SetActive(false);
            tekraroynabtn.SetActive(true);
            menuyedonbtn.SetActive(true);
            sontext.SetActive(true);
          
        }

    }

    void Update()
    {
      
        oyunubitir();
    }

  

   

   
}
