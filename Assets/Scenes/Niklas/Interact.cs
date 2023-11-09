using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Interact : MonoBehaviour
{
    private bool inChest = false;

    public GameObject chestInventory;

    public SceneManager House;

    private bool inHouse = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
        chestInventory.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Chest"))
        {
            inChest = true;
        }

        if (other.CompareTag("Door"))
        {
            //load house scene function her
            inHouse = true;
            if (inHouse)
            {
                //load previous scene
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Chest"))
        {
            inChest = false;
            chestInventory.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            if (inChest)
            {
                chestInventory.SetActive(true);
            }
        }
    }
}
