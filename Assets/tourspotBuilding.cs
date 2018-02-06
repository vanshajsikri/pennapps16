using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using LitJson;
using UnityEngine.UI;

public class tourspotBuilding : MonoBehaviour
{
    private Canvas foodCanvas_1;
    private Canvas hotelCanvas_1;
    private Canvas tourspotCanvas_1;

    private char buildingType = 'T';
    private string namePlace = "The Metropolitan Museum of Art";
    private string address = "1000 Fifth Avenue New York, NY";
    private string priceFactor = "Free";
    private string ratings = "5 stars";

    private RawImage rawImage;
    private string imageLink = "https://www.nyc-arts.org/wp-content/uploads/2011/07/Metropolitan_Museum_of_Art_at_1000_5th_Ave_.jpg";


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
        rawImage = GameObject.Find("Image_ts").GetComponent<RawImage>();
        rawImage.texture = www.texture;
    }

    // Update is called once per frame
    void Update()
    {

    }

    // OnTriggerEnter is called whenever an object enters the collider of the object attached with this script
    private void OnTriggerEnter(Collider other)
    {
		if (other.name == "First Person Controller 1" || other.name == "OVRPlayerController")
        {
            if (buildingType == 'T')
            {
                tourspotCanvas_1.enabled = true;
                GameObject.Find("namebuttonText_ts").GetComponent<Text>().text = namePlace;
                GameObject.Find("addressbuttonText_ts").GetComponent<Text>().text = address;
                GameObject.Find("pricebuttonText_ts").GetComponent<Text>().text = priceFactor;
                GameObject.Find("ratingbuttonText_ts").GetComponent<Text>().text = ratings;
            }
            if (buildingType == 'H')
                hotelCanvas_1.enabled = true;
            if (buildingType == 'F')
            {
                foodCanvas_1.enabled = true;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
		if (other.name == "First Person Controller 1" || other.name == "OVRPlayerController")
        {
            tourspotCanvas_1.enabled = false;
            GameObject.Find("namebuttonText_ts").GetComponent<Text>().text = "";
            GameObject.Find("addressbuttonText_ts").GetComponent<Text>().text = "";
            GameObject.Find("pricebuttonText_ts").GetComponent<Text>().text = "";
            GameObject.Find("ratingbuttonText_ts").GetComponent<Text>().text = "";
        }
    }
}
