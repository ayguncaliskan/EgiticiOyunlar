using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HayvanlarManager : MonoBehaviour
{
    [SerializeField]
    private AudioSource audioSource;
    [SerializeField]
    private AudioClip kopek; 
    [SerializeField]
    private AudioClip kedi; 
    [SerializeField]
    private AudioClip aslan;
    [SerializeField]
    private AudioClip maymun; 
    [SerializeField]
    private AudioClip kus;
    [SerializeField]
    private AudioClip balik; 
    [SerializeField]
    private AudioClip koyun;

    public RectTransform panel0, panel1, panel2, panel3, panel4, panel5, panel6, panel7;

    void Start()
    {

    }
    public void Hareketet0()
    {
        panel0.DOAnchorPos(new Vector2(-1080, 0), 0.5f);
        panel1.DOAnchorPos(Vector2.zero, 0.5f);
        audioSource.PlayOneShot(kopek);
    }
    public void GeriHareket0()
    {
        panel1.DOAnchorPos(new Vector2(-1080, 0), 0.5f);
        panel0.DOAnchorPos(Vector2.zero, 0.5f);
    }
    public void Hareketet1()
    {
        audioSource.PlayOneShot(kedi);
        panel1.DOAnchorPos(new Vector2(-1080, 0), 0.5f);
        panel2.DOAnchorPos(Vector2.zero, 0.5f);
    }
    public void GeriHareket1()
    {
        audioSource.PlayOneShot(kopek);
        panel2.DOAnchorPos(new Vector2(-1080, 0), 0.5f);
        panel1.DOAnchorPos(Vector2.zero, 0.5f);
    }
    public void Hareketet2()
    {
        audioSource.PlayOneShot(aslan);
        panel2.DOAnchorPos(new Vector2(-1080, 0), 0.5f);
        panel3.DOAnchorPos(Vector2.zero, 0.5f);
    }
    public void GeriHareket2()
    {
        audioSource.PlayOneShot(kedi);
        panel3.DOAnchorPos(new Vector2(-1080, 0), 0.5f);
        panel2.DOAnchorPos(Vector2.zero, 0.5f);
    }
    public void Hareketet3()
    {
        audioSource.PlayOneShot(maymun);
        panel3.DOAnchorPos(new Vector2(-1080, 0), 0.5f);
        panel4.DOAnchorPos(Vector2.zero, 0.5f);
    }
    public void GeriHareket3()
    {
        audioSource.PlayOneShot(aslan);
        panel4.DOAnchorPos(new Vector2(-1080, 0), 0.5f);
        panel3.DOAnchorPos(Vector2.zero, 0.5f);
    }
    public void Hareketet4()
    {
        audioSource.PlayOneShot(kus);
        panel4.DOAnchorPos(new Vector2(-1080, 0), 0.5f);
        panel5.DOAnchorPos(Vector2.zero, 0.5f);
    }
    public void GeriHareket4()
    {
        audioSource.PlayOneShot(maymun);
        panel5.DOAnchorPos(new Vector2(-1080, 0), 0.5f);
        panel4.DOAnchorPos(Vector2.zero, 0.5f);
    }
    public void Hareketet5()
    {
        audioSource.PlayOneShot(balik);
        panel5.DOAnchorPos(new Vector2(-1080, 0), 0.5f);
        panel6.DOAnchorPos(Vector2.zero, 0.5f);
    }
    public void GeriHareket5()
    {
        audioSource.PlayOneShot(kus);
        panel6.DOAnchorPos(new Vector2(-1080, 0), 0.5f);
        panel5.DOAnchorPos(Vector2.zero, 0.5f);
    }
    public void Hareketet6()
    {
        audioSource.PlayOneShot(koyun);
        panel6.DOAnchorPos(new Vector2(-1080, 0), 0.5f);
        panel7.DOAnchorPos(Vector2.zero, 0.5f);
    }
    public void GeriHareket6()
    {
        audioSource.PlayOneShot(balik);
        panel7.DOAnchorPos(new Vector2(-1080, 0), 0.5f);
        panel6.DOAnchorPos(Vector2.zero, 0.5f);
    }
}
