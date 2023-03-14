using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StepController : MonoBehaviour
{
    bool isFinished = false;

    public UnityEvent OnStepStart;


    public UnityEvent OnStepFinished;


    public void SetStepFinished()
    {
        isFinished = true;
    }

    public bool GetStepFinished()
    {
        return isFinished;
    }

    public virtual void FinishStep()
    {
        SetStepFinished();
        OnStepFinished.Invoke();
    }


}
