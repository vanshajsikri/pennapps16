using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using LitJson;
using UnityEngine.UI;

public class hotelBuilding : MonoBehaviour
{
    private Canvas foodCanvas_1;
    private Canvas hotelCanvas_1;
    private Canvas tourspotCanvas_1;

    private char buildingType = 'H';
    private string namePlace = "The Plaza Hotel";
    private string address = "768 5th Ave, New York, NY";
    private string priceFactor = "$786/night";
    private string ratings = "5 stars";
   
    private RawImage rawImage;
    private string imageLink = "https://exp.cdn-hotels.com/hotels/1000000/30000/28100/28044/8880843d_z.jpg";


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
        rawImage = GameObject.Find("Image_h").GetComponent<RawImage>();
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
            if (buildingType == 'H')
            {
                hotelCanvas_1.enabled = true;
                GameObject.Find("namebuttonText_h").GetComponent<Text>().text = namePlace;
                GameObject.Find("addressbuttonText_h").GetComponent<Text>().text = address;
                GameObject.Find("pricebuttonText_h").GetComponent<Text>().text = priceFactor;
                GameObject.Find("ratingbuttonText_h").GetComponent<Text>().text = ratings;
            }
            if (buildingType == 'T')
                tourspotCanvas_1.enabled = true;
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
            hotelCanvas_1.enabled = false;
            GameObject.Find("namebuttonText_h").GetComponent<Text>().text = "";
            GameObject.Find("addressbuttonText_h").GetComponent<Text>().text = "";
            GameObject.Find("pricebuttonText_h").GetComponent<Text>().text = "";
            GameObject.Find("ratingbuttonText_h").GetComponent<Text>().text = "";
        }
    }
}
