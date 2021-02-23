﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    private SpriteRenderer renderer;
    public bool isWalkAble = false;

    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HighLightMe(Color color)
    {
        Debug.Log("Light");
        renderer.color = color;
        isWalkAble = true;
    }

    public void UnHighLightMe()
    {
        renderer.color = Color.white;
        isWalkAble = false;
    }

    private void OnMouseDown()
    {
        if (isWalkAble)
        {
            GamaManager.Instance.MoveUnit(this.transform.position);
            GamaManager.Instance.UnitSelection(null, 0);
        }
        else
        {
            Debug.Log("Out of range");
        }
    }
}