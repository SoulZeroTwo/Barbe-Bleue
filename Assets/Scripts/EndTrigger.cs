using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    [Header("Anim. de Porte en question")]
    [SerializeField] private Animator _door;
    [Header("GameState")]
    [SerializeField] private GameState _gS;
    [Header("EndManager")]
    [SerializeField] private GameObject _eM;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// OnTriggerEnter is called when the Collider other enters the trigger.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    private void OnTriggerEnter(Collider other)
    {
        if(_gS.keyObtained && other.gameObject.CompareTag("Player"))
        {
            _door.SetTrigger("trigger");
            _eM.GetComponent<EndManager>().StartEndScene();
        }
    }
}
