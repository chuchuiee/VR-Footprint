using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using TMPro;
//using System;

public class showUI : MonoBehaviour
{
    public GameObject uiObject;
    // Start is called before the first frame update
    void Start()
    {
        uiObject.SetActive(false);
    }
    // Update is called once per frame
    void OnTriggerEnter (Collider coll)
    {
     if (coll.gameObject.tag == "Object")
        {
            uiObject.SetActive(true);
            Debug.Log("collide with object");
            //StartCoroutine("WaitForSec");
        }
    }
    private void OnTriggerExit(Collider coll)
    {
        uiObject.SetActive(false);
    }
    /*IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(5);
        Destroy(uiObject);
    }*/
}
