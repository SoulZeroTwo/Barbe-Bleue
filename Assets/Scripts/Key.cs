using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    [Header("Game Manager")]
    [SerializeField] private GameObject _gM;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// OnCollisionEnter is called when this collider/rigidbody has begun
    /// touching another rigidbody/collider.
    /// </summary>
    /// <param name="other">The Collision data associated with this collision.</param>
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("1");
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("2");
            _gM.GetComponent<GameManager>().OnKeyObtained();
            gameObject.SetActive(false);
        }
    }
}
