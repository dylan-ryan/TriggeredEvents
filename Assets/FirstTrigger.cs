using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class FirstTrigger : MonoBehaviour
{
    public PlayableDirector timeline;
    // Start is called before the first frame update
    void Start()
    {
        timeline = GetComponent<PlayableDirector>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if ( other.gameObject.CompareTag("Player"))
        {
            timeline.Play();
            
            
            
        }
    }
}
