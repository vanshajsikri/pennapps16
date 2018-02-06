using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using LitJson;
using UnityEngine.UI;

public class foodBuilding : MonoBehaviour {
    //private string jsonString;
    //private JsonData itemData;
    //private Text nameButton;

    private Canvas foodCanvas_1;
    private Canvas hotelCanvas_1;
    private Canvas tourspotCanvas_1;

    private char buildingType = 'F';
    private string namePlace = "Delmonico's Kitchen";
    private string address = "207 W 36th St, New York";
    private string priceFactor = "$$";
    private string ratings = "4.1/5.0";
    private string famousDish = "1876 Lobster Newberg";
    private RawImage rawImage;
    private string imageLink = "https://cdn.wedding-spot.com/images/venues/289/Delmonico's-Kitchen-Wedding-New-York-NY-01_main.1403508696.jpg";


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
		if(other.name == "OVRPlayerController")
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
		if (other.name == "OVRPlayerController")
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
