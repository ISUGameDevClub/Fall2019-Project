using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{ 
    private static int playerPoints = 0;
    [SerializeField]
    private Text pointsValueText;

    // Update is called once per frame
    void Update()
    {
        pointsValueText.text = playerPoints.ToString();
    }

    public int GetPoints()
    {
        return playerPoints;
    }

    public static void AddPoints(int pointsToAdd)
    {
        playerPoints += pointsToAdd;
    }
}
