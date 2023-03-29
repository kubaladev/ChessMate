using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessField : MonoBehaviour
{
    int xPos;
    int yPos;
    SpriteRenderer sr;
    public void Initialize(int xPos, int yPos, float xRealPos,float yRealPos, Color32 color)
    {
        sr = GetComponent<SpriteRenderer>();
        sr.color = color;
        this.xPos = xPos;
        this.yPos = yPos;
        transform.position = new Vector2(xRealPos, yRealPos);
    }
}
