using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class TrackedImageInfoRuntimeManager : MonoBehaviour
{
    [SerializeField] private Text debugLog;

    [SerializeField] private Text currentImageText;

    [SerializeField] private GameObject prefabOnTrack;

    [SerializeField] private Vector3 scaleFactor = new Vector3(0.1f, 0.1f, 0.1f);

    [SerializeField] XRReferenceImageLibrary xrReferenceImageLibrary;


    private ARTrackedImageManager trackImageManager;

    void Start()
    {
        debugLog.text += "Creating Runtime Mutable Image Library\n";

        trackImageManager = gameObject.AddComponent<ARTrackedImageManager>();
        trackImageManager.referenceLibrary = trackImageManager.CreateRuntimeLibrary(xrReferenceImageLibrary);
        trackImageManager.maxNumberOfMovingImages = 3;
        trackImageManager.trackedImagePrefab = prefabOnTrack;

        trackImageManager.enabled = true;
        trackImageManager.trackedImagesChanged += OnTrackedImagesChanged;
    }

    void OnDisable()
    {
        trackImageManager.trackedImagesChanged -= OnTrackedImagesChanged;
    }

    void OnTrackedImagesChanged(ARTrackedImagesChangedEventArgs eventArgs)
    {
        foreach(ARTrackedImage trackedImage in eventArgs.added)
        {
            currentImageText.text = trackedImage.referenceImage.name;
            trackedImage.transform.localScale = new Vector3(-trackedImage.referenceImage.size.x, 0.005f, -trackedImage.referenceImage.size.y);
        }

        foreach(ARTrackedImage trackedImage in eventArgs.updated)
        {
            currentImageText.text = trackedImage.referenceImage.name;
            trackedImage.transform.localScale = new Vector3(-trackedImage.referenceImage.size.x, 0.005f, -trackedImage.referenceImage.size.y);
        }
    }
}
