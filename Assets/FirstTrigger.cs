using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class FirstTrigger : MonoBehaviour
{
    public PlayableDirector timeline;
    public GameObject trigger;

    // Use this for initialization
    void Start()
    {
        timeline = GetComponent<PlayableDirector>();
    }


    //void OnTriggerExit(Collider c)
    //{
    //    if (c.gameObject.tag == "Player")
    //    {
    //        timeline.Stop();
    //    }
    //}

    void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag == "Player")
        {
            timeline.Play();
            
        }
    }
    private void OnTriggerExit(Collider c)
    {
        if (c.gameObject.tag == "Player")
        {
            trigger.SetActive(false);
        }
    }
}