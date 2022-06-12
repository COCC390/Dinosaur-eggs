using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggsController : MonoBehaviour
{
    #region Private variable

    [SerializeField] private float delayTime;
    [SerializeField] private float animationDelayTime;

    [SerializeField] private bool isStartSlide;

    #endregion

    #region Unity default method

    void Start()
    {
        isStartSlide = false;
        StartCoroutine(WaitForSlide(delayTime));

    }
               
    void Update()
    {
        if(isStartSlide)
        {
            StartCoroutine(SlideDownAnimation(animationDelayTime));
        }
    }

    #endregion

    #region Private method

    private IEnumerator WaitForSlide(float delayTime)
    {
        yield return new WaitForSeconds(delayTime);
        isStartSlide = true;        
    }

    private IEnumerator SlideDownAnimation(float animationDelay)
    {
        yield return null;
    }

    #endregion
}
