using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TasiKolay : MonoBehaviour
{
    Camera kamera;
    GameObject[] golgeler;
    Vector2 baslangicpoz;
    TasiKolaySon bitir_script;
    void Start()
    {
        kamera = GameObject.Find("Camera").GetComponent<Camera>();
        golgeler = GameObject.FindGameObjectsWithTag("golge");
        baslangicpoz = transform.position;
        bitir_script = GameObject.Find("OyunSon").GetComponent<TasiKolaySon>();

    }

    private void OnMouseDrag()
    {
        Vector3 pozisyon = kamera.ScreenToWorldPoint(Input.mousePosition);
        pozisyon.z = 0;
        transform.position = pozisyon;
    }
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            foreach (GameObject golge in golgeler)
            {
                if (gameObject.name == golge.name)
                {
                    float mesafe = Vector3.Distance(golge.transform.position, transform.position);
                    if (mesafe <= 1)
                    {
                        transform.position = golge.transform.position;
                        Destroy(this);
                        bitir_script.levelSon();
                    }
                    else
                    {
                        transform.position = baslangicpoz;
                    }
                }
            }
        }
    }
}
