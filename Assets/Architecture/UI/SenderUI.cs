using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SenderUI : MonoBehaviour
{
    private void Awake()
    {
        var descriptionObjects = GameObject.FindObjectsOfType<DescriptionSystem>();
        foreach (var descriptionObject in descriptionObjects)
            descriptionObject.SetDescriptionUI(GetComponent<Text>());
        transform.parent.gameObject.SetActive(false);
    }
}
