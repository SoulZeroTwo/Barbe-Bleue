using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("GameState")]
    [SerializeField] private GameState _gS;
    // Start is called before the first frame update
    void Start()
    {
        _gS.keyObtained = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnKeyObtained()
    {
        _gS.keyObtained = true;
    }
}
