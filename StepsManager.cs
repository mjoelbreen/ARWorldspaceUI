using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using TMPro;
using UnityEngine.UI;

public class StepsManager : MonoBehaviour
{
    public static StepsManager instance;

    public List<StepController> stepsList;


    int currentStepIndex = -1;

    
    private void Begin()
    {
        StepController[] stepsArray = GetComponentsInChildren<StepController>(true);

         stepsList = stepsArray.OfType<StepController>().ToList();

    }
    
    [ContextMenu("StartNextStep")]
    public void StartNextStep()
    {
        if (currentStepIndex == stepsList.Count()) return;

        if (currentStepIndex > -1)
        {
            StepController finishedStep = stepsList[currentStepIndex];

            finishedStep.FinishStep();
            finishedStep.gameObject.SetActive(false);
        }

        currentStepIndex += 1;

        if (currentStepIndex == stepsList.Count()) return;

        StepController nextStep = stepsList[currentStepIndex];

        nextStep.gameObject.SetActive(true);
        nextStep.OnStepStart.Invoke();

    }

    public void BackStep()
    {
        if(currentStepIndex > -1)
        {
            StepController finishedStep = stepsList[currentStepIndex];
            finishedStep.FinishStep();
            finishedStep.gameObject.SetActive(false);
            currentStepIndex--;
            StepController prevStep = stepsList[currentStepIndex];
            prevStep.gameObject.SetActive(true);
            prevStep.OnStepStart.Invoke();

        }
    }


    public void SetupStepsManager(Button nextButton, Button prevButton)
    {
        nextButton.onClick.AddListener(StartNextStep);
        prevButton.onClick.AddListener(BackStep);

        StartNextStep();
    }
}
