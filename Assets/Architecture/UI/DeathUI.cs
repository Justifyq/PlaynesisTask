using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathUI : MonoBehaviour
{
    private void Awake()
    {
        GameObject.FindObjectOfType<HealthSystem>().SetDeathUI(this);
        gameObject.SetActive(false);
    }

    public void ShowDeathUI()
    {
        gameObject.SetActive(true);
    }
}
