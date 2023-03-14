using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckmarkAnimationHelper : MonoBehaviour
{
    public List<Sprite> textures;
    public Image image;

    public float secondsToWait = .1f;

    public float secondsToEndScene = 5f;

    [ContextMenu("Play Animation")]
    public void PlayAnimation()
    {
        StartCoroutine("PlayAnimationCouroutine");
    }

    IEnumerator PlayAnimationCouroutine()
    {
        AuthoringController.instance.FinishAuthoring();

        int index = 0;

        foreach(Sprite sprite in textures)
        {
            image.sprite = sprite;

            yield return new WaitForSeconds(secondsToWait);
        }

        yield return new WaitForSeconds(secondsToEndScene);

        SceneController.ChangeScene(1);
    }
}
