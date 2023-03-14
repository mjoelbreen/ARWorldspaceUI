using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ImageTrackingLibraryManager : MonoBehaviour
{
    [SerializeField] XRReferenceImageLibrary firstLibrary = null;
    [SerializeField] XRReferenceImageLibrary secondLibrary = null;
    [SerializeField] ARTrackedImageManager manager = null;
    [SerializeField] int sceneIndex;

    void Start()
    {
        manager.enabled = false;
    }
    

    void switchImageLibrary()
    {

    }
}
