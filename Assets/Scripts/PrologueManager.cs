using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrologueManager : MonoBehaviour
{
    [SerializeField] private GameObject _prologueCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TogglePrologue()
    {
        _prologueCanvas.SetActive(!_prologueCanvas.activeSelf);
    }
}
