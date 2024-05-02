using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.UI;

public class EndManager : MonoBehaviour
{
    [Header("Joueur")]
    [SerializeField] private GameObject _player;
    [Header("Virtual Camera")]
    [SerializeField] private GameObject _vCam1;
    [SerializeField] private GameObject _vCam2;
    [Header("Barbe Bleue")]
    [SerializeField] private GameObject _bB;
    [Header("Canvas1")]
    [SerializeField] private GameObject _canvas1;
    [Header("Canvas2")]
    [SerializeField] private GameObject _canvas2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartEndScene()
    {
        _vCam1.SetActive(true);
        _player.SetActive(false);
        Invoke("AnimBB", 3);
    }

    void AnimBB()
    {
        _bB.SetActive(true);
        _vCam2.SetActive(true);
        _vCam1.SetActive(false);
        Invoke("ActivateCanvas1", 4.9f);
    }

    void ActivateCanvas1()
    {
        _canvas1.SetActive(true);
        Invoke("ActivateCanvas2", 0.05f);
    }
    void ActivateCanvas2()
    {
        _canvas2.SetActive(true);
    }
}
