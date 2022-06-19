using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggsController : MonoBehaviour
{
    #region Private variable

    [SerializeField] private float delayTime;
    [SerializeField] private float animationDelayTime;

    #endregion

    #region Unity default method

    void Start()
    {
        StartCoroutine(WaitForSlide(delayTime));
    }
               
    void Update()
    {
    }

    #endregion

    #region Private method

    private IEnumerator WaitForSlide(float delayTime)
    {
        yield return new WaitForSeconds(delayTime);
        StartCoroutine(RunMoveDownAnimation(animationDelayTime));
    }

    private IEnumerator RunMoveDownAnimation(float animationDelayTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(animationDelayTime);
            MoveDownAnimation();
        }
    }

    private void MoveDownAnimation()
    {
        this.transform.Translate(Vector3.down * 0.16f);
    }

    #endregion
}
