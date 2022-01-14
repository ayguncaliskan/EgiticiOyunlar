using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tasi : MonoBehaviour
{
    son son;
    Camera kamera;

    public AudioSource source;
    public AudioClip dogru;
    public AudioClip yanlis;
    Vector2 baslangicpoz;
    //kutuları bu dizinin içine atıcaz
    GameObject[] kutular;
    //OnMouseDrag: Collider bileşenine sahip bir objenin üzerine fare ile tıklandığında ve tıklama bırakılmadan fare hareket ettirildiği süre boyunca çağrılan fonksiyondur.
    private void OnMouseDrag()
    {
        //mause pozisyonunu alıyoruz
        Vector3 pozisyon = kamera.ScreenToWorldPoint(Input.mousePosition);
        //oyunumuz 2 boyutlu o yüzden zyi sıfırlıyoruz
        pozisyon.z = 0;
        //Resmimizin pozisyonunu eşitledik
        transform.position = pozisyon;
    }
    void Start()
    {
        //kamerayı buluyoruz
        kamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        //baslangic pozu transformu atıyoruz
        baslangicpoz = transform.position;
        //kutuları tagına göre buluyoruz
        kutular = GameObject.FindGameObjectsWithTag("kutu");
        //son = GameObject.Find("Son").GetComponent<son>();
        
    }
  public void GeriDon()
    {
        SceneManager.LoadScene("PuzzleLevel");
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            foreach (GameObject kutu in kutular)
            {
                //eger kutu isimleri aynıysa ve aralarındaki mesafe 1den küçükse eşleştir
                if (kutu.name == gameObject.name)
                {
                    float mesafe = Vector3.Distance(kutu.transform.position, transform.position);
                    if (mesafe <= 1)
                    {
                        transform.position = kutu.transform.position;
                        Destroy(this);
                        //son.sayi_arttir();
                        this.enabled = false;
                        source.clip = dogru;
                        source.Play();
                        kutu.SetActive(false);
                    }
                    //değilse başlangıça geri döndür
                    else
                    {
                        transform.position = baslangicpoz;
                        source.clip = yanlis;
                        source.Play();
                    }
                }
            }
        }
    }
}
