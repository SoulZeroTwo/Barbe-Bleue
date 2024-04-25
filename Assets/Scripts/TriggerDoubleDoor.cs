using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoubleDoor : MonoBehaviour
{
    [Header("Animators")]
    [SerializeField] private Animator _animatorBG1;
    [SerializeField] private Animator _animatorBG2;
    [SerializeField] private Animator _animatorDoorLeft;
    [SerializeField] private Animator _animatorDoorRight;
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
        if(other.gameObject.CompareTag("Player"))
        {
            _animatorBG1.SetTrigger("trigger");
            _animatorBG2.SetTrigger("trigger");
            _animatorDoorLeft.SetTrigger("trigger");
            _animatorDoorRight.SetTrigger("trigger");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            _animatorBG1.SetTrigger("trigger");
            _animatorBG2.SetTrigger("trigger");
            _animatorDoorLeft.SetTrigger("trigger");
            _animatorDoorRight.SetTrigger("trigger");
        }
    }
}
