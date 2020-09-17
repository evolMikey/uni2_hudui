using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class src_SavesSystem : MonoBehaviour {

    public Texture2D saveScreenshot;
    private Transform scrnShotLocation;
    public string save_Date;
    public string save_CharName;
    public string save_Location;

    private void Start()
    {
        scrnShotLocation = transform.parent.parent.parent.parent.Find("gameScreenshot");
        transform.Find("saveDate").GetComponent<Text>().text = save_Date;
        transform.Find("charNameLevel").GetComponent<Text>().text = save_CharName;
        transform.Find("saveLocation").GetComponent<Text>().text = save_Location;
    }

    public void OnMouseDown()
    {
        Debug.Log("CLICKED!");
        scrnShotLocation.GetComponent<RawImage>().texture = saveScreenshot;
        scrnShotLocation.Find("RawImage").Find("saveDate").GetComponent<Text>().text = save_Date;
        scrnShotLocation.Find("RawImage").Find("charNameLevel").GetComponent<Text>().text = save_CharName;
        scrnShotLocation.Find("RawImage").Find("saveLocation").GetComponent<Text>().text = save_Location;
    }
}
