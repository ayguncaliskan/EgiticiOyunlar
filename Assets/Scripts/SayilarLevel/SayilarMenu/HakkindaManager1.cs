﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HakkindaManager1 : MonoBehaviour
{
    [SerializeField]
    private GameObject hakkindaPaneli;

    public void menudon()
    {
        hakkindaPaneli.SetActive(false);
        SceneManager.LoadScene("MenuLevel");
    }
}
