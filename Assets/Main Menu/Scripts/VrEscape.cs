﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VrEscape : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject vrPlay;
    public GameObject vrVideoPlayer;
    public GameObject vrlist;
    public GameObject exitPopUp;
    void Start()
    {
        vrlist.SetActive(true);
        vrPlay.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(vrPlay.activeSelf)
            {
                vrlist.GetComponent<CanvasGroup>().alpha = 1;
                vrlist.GetComponent<CanvasGroup>().blocksRaycasts = true;
                vrPlay.SetActive(false);
                vrVideoPlayer.SetActive(false);
            }
            else
            {
                exitPopUp.SetActive(true);
            }
        }
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
     public void closePopUp()
    {
      exitPopUp.SetActive(false);
    }

}