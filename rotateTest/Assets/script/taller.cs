using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class taller : MonoBehaviour {

    public Vector3 cube_scale;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {

            this.transform.DOScale(this.transform.localScale+cube_scale,2);

        }
	}
}
