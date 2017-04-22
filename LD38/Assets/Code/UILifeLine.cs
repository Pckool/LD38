﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UILifeLine : MonoBehaviour {
  LifeLine life;
  Image image;
	// Use this for initialization
	void Start () {
    image = GetComponent<Image>();
    life = transform.root.GetComponent<LifeLine>();
	}
	
	// Update is called once per frame
	void Update () {
    image.fillAmount = life.life / 100f;
	}
}
