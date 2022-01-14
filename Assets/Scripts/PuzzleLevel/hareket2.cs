using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareket2 : MonoBehaviour
{
    Camera kamera;
    GameObject[] golgeler;
    Vector2 baslangicpoz;
    Bitir bitir_script;
    void Start()
    {
        kamera = GameObject.Find("MainCamera").GetComponent<Camera>();
        golgeler = GameObject.FindGameObjectsWithTag("golge");
        baslangicpoz = transform.position;
        bitir_script = GameObject.Find("Bitir").GetComponent<Bitir>();

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
                if (gameObject.name==golge.name)
                {
                    float mesafe = Vector3.Distance(golge.transform.position, transform.position);
                    if (mesafe <=1)
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
