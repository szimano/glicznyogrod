using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour {

	public int fadeInTime;

	private Image image;

	private long timeStart;

	// Use this for initialization
	void Start () {
		image = GetComponent<Image>();
		timeStart = System.DateTime.Now.ToFileTime();	
	}
	
	// Update is called once per frame
	void Update () {
		if (System.DateTime.Now.ToFileTime() > (timeStart + fadeInTime)) {
			Destroy(gameObject);
		} else {
			Color color = image.color;
			double newAlpha = 1 - ((double)(System.DateTime.Now.ToFileTime() - timeStart) / (double)fadeInTime);
			color.a = (float)newAlpha;  
			image.color = color;
		}		
	}
}
