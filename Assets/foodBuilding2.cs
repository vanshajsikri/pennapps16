using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using LitJson;
using UnityEngine.UI;

public class foodBuilding2 : MonoBehaviour {
    //private string jsonString;
    //private JsonData itemData;
    //private Text nameButton;

    private Canvas foodCanvas_1;
    private Canvas hotelCanvas_1;
    private Canvas tourspotCanvas_1;

    private char buildingType = 'F';
    private string namePlace = "Tortelleria Nixtamal";
	private string address = "04-05 47th Ave, Corona, NY";
    private string priceFactor = "$$";
    private string ratings = "4.5/5.0";
    private string famousDish = "Tacos";
    private RawImage rawImage;
	private string imageLink = "https://lh3.googleusercontent.com/-Efc4c0_5bpg/VBHJwr9FPJI/AAAAAAAE1o8/kPGEuW0c4VU4WGp8nZ4isA1lioVNERSvgCJkC/w480-h320-k-no/";


    // Use this for initialization
    
    IEnumerator Start()
    {
        foodCanvas_1 = GameObject.Find("foodCanvas").GetComponent<Canvas>();
        foodCanvas_1.enabled = false;
        hotelCanvas_1 = GameObject.Find("hotelCanvas").GetComponent<Canvas>();
        hotelCanvas_1.enabled = false;
        tourspotCanvas_1 = GameObject.Find("tourspotCanvas").GetComponent<Canvas>();
        tourspotCanvas_1.enabled = false;
        WWW www = new WWW(imageLink);
        yield return www;
        rawImage = GameObject.Find("Image").GetComponent<RawImage>();
        rawImage.texture = www.texture;
    }

    // Update is called once per frame
    void Update () {
        //GetData();
        //nameButton = GameObject.Find("namebuttonText").GetComponent<Text>();
        //nameButton.text = itemData["results"][1]["name"].ToString();
        //nameButton.text = jsonString;
        //Debug.Log(nameButton.text);
    }

    // OnTriggerEnter is called whenever an object enters the collider of the object attached with this script
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "First Person Controller 1")
        {
            if (buildingType == 'F')
            {
                foodCanvas_1.enabled = true;
                GameObject.Find("namebuttonText").GetComponent<Text>().text = namePlace;
                GameObject.Find("addressbuttonText").GetComponent<Text>().text = address;
                GameObject.Find("cuisinebuttonText").GetComponent<Text>().text = famousDish;
                GameObject.Find("ratingbuttonText").GetComponent<Text>().text = ratings;
                GameObject.Find("pricebuttonText").GetComponent<Text>().text = priceFactor;
            }
            if (buildingType == 'H')
                hotelCanvas_1.enabled = true;
            if (buildingType == 'T')
                tourspotCanvas_1.enabled = true;
            
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "First Person Controller 1")
        {
            foodCanvas_1.enabled = false;
            GameObject.Find("namebuttonText").GetComponent<Text>().text = "";
            GameObject.Find("addressbuttonText").GetComponent<Text>().text = "";
            GameObject.Find("cuisinebuttonText").GetComponent<Text>().text = "";
            GameObject.Find("ratingbuttonText").GetComponent<Text>().text = "";
            GameObject.Find("pricebuttonText").GetComponent<Text>().text = "";
        }
    }

    //private JsonData getjsonData(string field, string key)
    //{
    //    for (int i = 0; i < itemData[key].Count; i++)
    //    {
    //        if (itemData[key][i]["name"].ToString() == field)
    //        {
    //            return itemData[key][i];
    //        }
    //    }

    //    return null;
    //}
}
