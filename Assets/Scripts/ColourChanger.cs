using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChanger : MonoBehaviour {

    public Color[] AvailableColours;
    public SpriteRenderer Sprite;
    private int _index;

    private void Awake () {
        Debug.Log("Wake me up");

        if (Sprite == null) {
            Sprite = GetComponent<SpriteRenderer>();
        }

        if (AvailableColours.Length == 0) {
            Debug.LogError("No colours available...");
        }
    }

    private void OnEnable()    {

        
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log("Wake me up inside");

        
         if (Input.GetKeyDown(KeyCode.Space)) {
            if (_index < AvailableColours.Length -1)
                _index ++;
            else
                _index = 0;

            Sprite.color = AvailableColours[_index];
        }

    }

    private void FixedUpdate () {

        Debug.Log("I can't wake up");
    }

    private void OnDisable () {
        Debug.Log("SAVE ME");
    }

    private void OnDestroy () {
        Debug.Log("Call my name and save me from the dark");

    }


   
    
}
