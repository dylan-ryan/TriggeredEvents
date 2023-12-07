using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esacpemenu : MonoBehaviour
{
    public GameObject player;
    public GameObject escapeMenu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (player == isActiveAndEnabled)
            escapeMenu.SetActive(true);
            player.SetActive(false);

            if (player != isActiveAndEnabled)
            {
                escapeMenu.SetActive(false);
                player.SetActive(true);
            }
        }

        
    }
}
