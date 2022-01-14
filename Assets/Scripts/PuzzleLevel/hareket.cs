using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareket : MonoBehaviour
{

    public GameObject correctform;
    private bool hareketlimi;
    private bool eslestir;
    private float baslangicpozX;
    private float baslangicpozY;
    private Vector3 pozisyonuSifirla;

    private void Start()
    {
        pozisyonuSifirla = this.transform.localPosition;
    }
    private void Update()
    {
        if (eslestir == false)
        {
            if (hareketlimi)
            {
                Vector3 pozisyon;
                pozisyon = Input.mousePosition;
                pozisyon = Camera.main.ScreenToWorldPoint(pozisyon);
                this.gameObject.transform.localPosition = new Vector3(pozisyon.x - baslangicpozX, pozisyon.y - baslangicpozY, this.gameObject.transform.localPosition.z);
            }
        }

    }
    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 pozisyon;
            pozisyon = Input.mousePosition;
            pozisyon = Camera.main.ScreenToWorldPoint(pozisyon);
            baslangicpozX = pozisyon.x - this.transform.localPosition.x;
            baslangicpozY = pozisyon.y - this.transform.localPosition.y;
            hareketlimi = true;
        }
    }
    private void OnMouseUp()
    {
        hareketlimi = false;
        if (Mathf.Abs(this.transform.localPosition.x - correctform.transform.localPosition.x) <= 0.5f &&
        Mathf.Abs(this.transform.localPosition.y - correctform.transform.localPosition.y) <= 0.5f)
        {
            this.transform.position = new Vector3(correctform.transform.position.x, correctform.transform.position.y, correctform.transform.position.z);
            eslestir = true;
        }
        else
        {
            this.transform.localPosition = new Vector3(pozisyonuSifirla.x, pozisyonuSifirla.y, pozisyonuSifirla.z);
        }
    }
}

