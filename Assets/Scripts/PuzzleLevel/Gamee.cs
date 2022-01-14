using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Gamee : MonoBehaviour
{
    public RectTransform panel1, panel2, panel3, panel4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Hareketet1()
    {
        panel1.DOAnchorPos(new Vector2(-1093,0),0.5f);
        panel2.DOAnchorPos(Vector2.zero, 0.5f);    
    }    public void Hareketet2()
    {
        panel2.DOAnchorPos(new Vector2(-1093,0),0.5f);
        panel3.DOAnchorPos(Vector2.zero, 0.5f);    
    }    public void Hareketet3()
    {
        panel3.DOAnchorPos(new Vector2(-1093,0),0.5f);
        panel4.DOAnchorPos(Vector2.zero, 0.5f);    
    }  
}
