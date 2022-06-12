using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggsBoardController : MonoBehaviour
{
    #region Private variable

    [SerializeField] private GameObject[] eggsPrefab;
    [SerializeField] private int columnLimit;
    [SerializeField] private Vector2 generatePos;

    private GameObject randomEggs;
    private int randomEggsInList;
    private int numberOfEggsInRow;

    #endregion

    #region Unity default method

    private void Awake()
    {
        StartCoroutine(AutoGenerate());
    }

    #endregion
      
    void Update()
    {
        
    }

    #region Private method

    private void EggsGenerate(int numberEggsInRow)
    {
        for(int i = 0; i < numberEggsInRow; i++)
        {
            randomEggsInList = Random.Range(0, eggsPrefab.Length - 1);
            randomEggs = eggsPrefab[randomEggsInList];
            Instantiate(randomEggs, generatePos, Quaternion.identity);
            generatePos = new Vector2(generatePos.x + 0.16f, generatePos.y);
        }
    }

    private IEnumerator AutoGenerate()
    {
        for(int i = 0; i < columnLimit; i++)
        {
            if(i % 2 == 0)
            {
                numberOfEggsInRow = 7;
                generatePos.x = -0.48f;
            }
            else
            {
                numberOfEggsInRow = 6;
                generatePos.x = -0.4f;
            }

            EggsGenerate(numberOfEggsInRow);
            generatePos.y += 0.16f;

            yield return null;
        }
    }

    #endregion
}
