using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuzzleZorManager : MonoBehaviour
{

    public GameObject resim1, resim2, resim3, resim4, resim5, resim6, resim7, resim8, resim9, resim10, resim11, resim12, resim13, resim14, resim15, resim16,
        resim1Black, resim2Black, resim3Black, resim4Black, resim5Black, resim6Black, resim7Black, resim8Black, resim9Black, resim10Black, resim11Black, resim12Black, resim13Black, resim14Black, resim15Black, resim16Black, tekraroynabtn, menuyedonbtn, sontext;


    Vector3 ilkresim1Position, ilkresim2Position, ilkresim3Position, ilkresim4Position, ilkresim5Position, ilkresim6Position, ilkresim7Position,
    ilkresim8Position, ilkresim9Position, ilkresim10Position, ilkresim11Position, ilkresim12Position, ilkresim13Position, ilkresim14Position, ilkresim15Position, ilkresim16Position;
    //resimler eslesmeleri kontrol etmek için
    bool resim1Bool, resim2Bool, resim3Bool, resim4Bool, resim5Bool, resim6Bool, resim7Bool, resim8Bool, resim9Bool, resim10Bool, resim11Bool, resim12Bool, resim13Bool, resim14Bool, resim15Bool, resim16Bool = false;

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
        ilkresim6Position = resim6.transform.position;
        ilkresim7Position = resim7.transform.position;
        ilkresim8Position = resim8.transform.position;
        ilkresim9Position = resim9.transform.position;
        ilkresim10Position = resim10.transform.position;
        ilkresim11Position = resim11.transform.position;
        ilkresim12Position = resim12.transform.position;
        ilkresim13Position = resim13.transform.position;
        ilkresim14Position = resim14.transform.position;
        ilkresim15Position = resim15.transform.position;
        ilkresim16Position = resim16.transform.position;
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
    public void Surukleresim6()
    {


        resim6.transform.position = Input.mousePosition;

    }
    public void Surukleresim7()
    {


        resim7.transform.position = Input.mousePosition;

    }

    public void Surukleresim8()
    {


        resim8.transform.position = Input.mousePosition;

    }

    public void Surukleresim9()
    {


        resim9.transform.position = Input.mousePosition;

    }

    public void Surukleresim10()
    {

        resim10.transform.position = Input.mousePosition;

    }




    public void Surukleresim11()
    {


        resim11.transform.position = Input.mousePosition;

    }
    public void Surukleresim12()
    {


        resim12.transform.position = Input.mousePosition;

    }

    public void Surukleresim13()
    {


        resim13.transform.position = Input.mousePosition;

    }

    public void Surukleresim14()
    {


        resim14.transform.position = Input.mousePosition;

    }

    public void Surukleresim15()
    {

        resim15.transform.position = Input.mousePosition;

    }
    public void Surukleresim16()
    {

        resim16.transform.position = Input.mousePosition;

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
    public void Birakresim6()
    {
        //aradaki mesafe hesaplanır 50den küçükse eşleştir ve dogru sesini çal değilse ilk haline geri döndür
        float distance = Vector3.Distance(resim6.transform.position, resim6Black.transform.position);
        if (distance < 50)
        {
            resim6.transform.position = resim6Black.transform.position;

            resim6Bool = true;
            source.clip = dogru;
            source.Play();

        }
        else

        {
            resim6.transform.position = ilkresim6Position;
            source.clip = yanlis;
            source.Play();
        }




    }

    public void Birakresim7()
    {

        float distance = Vector3.Distance(resim7.transform.position, resim7Black.transform.position);
        if (distance < 50)
        {
            resim7.transform.position = resim7Black.transform.position;

            resim7Bool = true;
            source.clip = dogru;
            source.Play();
        }
        else
        {
            resim7.transform.position = ilkresim7Position;
            source.clip = yanlis;
            source.Play();
        }

    }

    public void Birakresim8()
    {

        float distance = Vector3.Distance(resim8.transform.position, resim8Black.transform.position);
        if (distance < 50)
        {

            resim8.transform.position = resim8Black.transform.position;

            resim8Bool = true;
            source.clip = dogru;
            source.Play();
        }
        else
        {
            resim8.transform.position = ilkresim8Position;
            source.clip = yanlis;
            source.Play();
        }

    }


    public void Birakresim9()
    {

        float distance = Vector3.Distance(resim9.transform.position, resim9Black.transform.position);
        if (distance < 50)
        {

            resim9.transform.position = resim9Black.transform.position;
            resim9.transform.localScale = resim9Black.transform.localScale;

            resim9Bool = true;
            source.clip = dogru;
            source.Play();
        }
        else
        {
            resim9.transform.position = ilkresim9Position;
            source.clip = yanlis;
            source.Play();
        }



    }
    public void Birakresim10()
    {

        float distance = Vector3.Distance(resim10.transform.position, resim10Black.transform.position);
        if (distance < 50)
        {

            resim10.transform.position = resim10Black.transform.position;

            resim10Bool = true;
            source.clip = dogru;
            source.Play();
        }
        else
        {
            resim10.transform.position = ilkresim10Position;
            source.clip = yanlis;
            source.Play();
        }
    }
    public void Birakresim11()
    {
        //aradaki mesafe hesaplanır 50den küçükse eşleştir ve dogru sesini çal değilse ilk haline geri döndür
        float distance = Vector3.Distance(resim11.transform.position, resim11Black.transform.position);
        if (distance < 50)
        {
            resim11.transform.position = resim11Black.transform.position;

            resim11Bool = true;
            source.clip = dogru;
            source.Play();

        }
        else

        {
            resim11.transform.position = ilkresim11Position;
            source.clip = yanlis;
            source.Play();
        }




    }

    public void Birakresim12()
    {

        float distance = Vector3.Distance(resim12.transform.position, resim12Black.transform.position);
        if (distance < 50)
        {
            resim12.transform.position = resim12Black.transform.position;

            resim12Bool = true;
            source.clip = dogru;
            source.Play();
        }
        else
        {
            resim12.transform.position = ilkresim12Position;
            source.clip = yanlis;
            source.Play();
        }

    }

    public void Birakresim13()
    {

        float distance = Vector3.Distance(resim13.transform.position, resim13Black.transform.position);
        if (distance < 50)
        {

            resim13.transform.position = resim13Black.transform.position;

            resim13Bool = true;
            source.clip = dogru;
            source.Play();
        }
        else
        {
            resim13.transform.position = ilkresim13Position;
            source.clip = yanlis;
            source.Play();
        }

    }


    public void Birakresim14()
    {

        float distance = Vector3.Distance(resim14.transform.position, resim14Black.transform.position);
        if (distance < 50)
        {

            resim14.transform.position = resim14Black.transform.position;
            resim14.transform.localScale = resim14Black.transform.localScale;

            resim14Bool = true;
            source.clip = dogru;
            source.Play();
        }
        else
        {
            resim14.transform.position = ilkresim14Position;
            source.clip = yanlis;
            source.Play();
        }



    }
    public void Birakresim15()
    {

        float distance = Vector3.Distance(resim15.transform.position, resim15Black.transform.position);
        if (distance < 50)
        {

            resim15.transform.position = resim15Black.transform.position;

            resim15Bool = true;
            source.clip = dogru;
            source.Play();
        }
        else
        {
            resim15.transform.position = ilkresim15Position;
            source.clip = yanlis;
            source.Play();
        }
    }
    public void Birakresim16()
    {

        float distance = Vector3.Distance(resim16.transform.position, resim16Black.transform.position);
        if (distance < 50)
        {

            resim16.transform.position = resim16Black.transform.position;

            resim16Bool = true;
            source.clip = dogru;
            source.Play();
        }
        else
        {
            resim16.transform.position = ilkresim16Position;
            source.clip = yanlis;
            source.Play();
        }



    }

    public void tekrarOyna()
    {
        SceneManager.LoadScene("ZorPuzzle");
    }
    public void menuyedon()
    {
        SceneManager.LoadScene("PuzzleLevel");
    }
    //tüm resimler dogru ise objelerini set activelerini kapat diğer elemanları aç
    public void oyunubitir()
    {
        if (resim1Bool && resim2Bool && resim3Bool && resim4Bool && resim5Bool &&
        resim6Bool && resim7Bool && resim8Bool && resim9Bool && resim10Bool &&
        resim11Bool && resim12Bool && resim13Bool && resim14Bool && resim15Bool && resim16Bool == true)
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
            resim6.SetActive(false);
            resim6Black.SetActive(false);
            resim7.SetActive(false);
            resim7Black.SetActive(false);
            resim8.SetActive(false);
            resim8Black.SetActive(false);
            resim9.SetActive(false);
            resim9Black.SetActive(false);
            resim10.SetActive(false);
            resim10Black.SetActive(false);
            resim11.SetActive(false);
            resim11Black.SetActive(false);
            resim12.SetActive(false);
            resim12Black.SetActive(false);
            resim13.SetActive(false);
            resim13Black.SetActive(false);
            resim14.SetActive(false);
            resim14Black.SetActive(false);
            resim15.SetActive(false);
            resim15Black.SetActive(false); 
            resim16.SetActive(false);
            resim16Black.SetActive(false);
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





