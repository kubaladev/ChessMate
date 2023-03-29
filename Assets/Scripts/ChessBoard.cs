using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessBoard : MonoBehaviour
{
    [SerializeField] ChessField chessField;
    [SerializeField] Vector2 boardStartingPosition;
    [SerializeField] Color32 blackColor,whiteColor;
    
    void Start()
    {
        float pieceDistance = chessField.GetComponent<SpriteRenderer>().bounds.size.x;
        bool isNextPositionBlack = true;
        for(int i = 0; i < 8; i++)
        {
            for(int d=0; d < 8; d++)
            {
                ChessField createdField = Instantiate(chessField);
                Color32 nextColor = isNextPositionBlack ?  blackColor : nextColor = whiteColor;
                isNextPositionBlack = !isNextPositionBlack;
                createdField.Initialize(d, i, boardStartingPosition.x + d * pieceDistance, boardStartingPosition.y + i * pieceDistance,nextColor);
            }
            isNextPositionBlack = !isNextPositionBlack;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
