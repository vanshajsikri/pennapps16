using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class imageLoader : MonoBehaviour {

    private RawImage rawImage;
    private string imageLink = "https://cdn.wedding-spot.com/images/venues/289/Delmonico's-Kitchen-Wedding-New-York-NY-01_main.1403508696.jpg";
    IEnumerator Start()
    {
        WWW www = new WWW(imageLink);
        yield return www;
        rawImage = GameObject.Find("Image").GetComponent<RawImage>();
        rawImage.texture = www.texture;
    }
}
