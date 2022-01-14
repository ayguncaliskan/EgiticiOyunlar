using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RenklerManager : MonoBehaviour
{
    // Start is called before the first frame update
    public RectTransform panel0, panel1, panel2, panel3, panel4,panel5,panel6;

    void Start()
    {
        
    }
    public void Hareketet0()
    {
        panel0.DOAnchorPos(new Vector2(-1080, 0), 0.5f);
        panel1.DOAnchorPos(Vector2.zero, 0.5f);
    }
    public void GeriHareket0()
    {
        panel1.DOAnchorPos(new Vector2(-1080, 0), 0.5f);
        panel0.DOAnchorPos(Vector2.zero, 0.5f);
    }
    public void Hareketet1()
    {
        panel1.DOAnchorPos(new Vector2(-1080, 0), 0.5f);
        panel2.DOAnchorPos(Vector2.zero, 0.5f);
    }
    public void GeriHareket1()
    {
        panel2.DOAnchorPos(new Vector2(-1080, 0), 0.5f);
        panel1.DOAnchorPos(Vector2.zero, 0.5f);
    }
    public void Hareketet2()
    {
        panel2.DOAnchorPos(new Vector2(-1080, 0), 0.5f);
        panel3.DOAnchorPos(Vector2.zero, 0.5f);
    }
    public void GeriHareket2()
    {
        panel3.DOAnchorPos(new Vector2(-1080, 0), 0.5f);
        panel2.DOAnchorPos(Vector2.zero, 0.5f);
    }
    public void Hareketet3()
    {
        panel3.DOAnchorPos(new Vector2(-1080, 0), 0.5f);
        panel4.DOAnchorPos(Vector2.zero, 0.5f);
    }
    public void GeriHareket3()
    {
        panel4.DOAnchorPos(new Vector2(-1080, 0), 0.5f);
        panel3.DOAnchorPos(Vector2.zero, 0.5f);
    }
    public void Hareketet4()
    {
        panel4.DOAnchorPos(new Vector2(-1080, 0), 0.5f);
        panel5.DOAnchorPos(Vector2.zero, 0.5f);
    }
    public void GeriHareket4()
    {
        panel5.DOAnchorPos(new Vector2(-1080, 0), 0.5f);
        panel4.DOAnchorPos(Vector2.zero, 0.5f);
    }
    public void Hareketet5()
    {
        panel5.DOAnchorPos(new Vector2(-1080, 0), 0.5f);
        panel6.DOAnchorPos(Vector2.zero, 0.5f);
    }
    public void GeriHareket5()
    {
        panel6.DOAnchorPos(new Vector2(-1080, 0), 0.5f);
        panel5.DOAnchorPos(Vector2.zero, 0.5f);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
