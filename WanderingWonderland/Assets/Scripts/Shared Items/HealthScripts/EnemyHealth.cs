using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : Health
{

    public RectTransform healthBar;


    private void Update()
    {
        transform.LookAt(Camera.main.transform);
        healthBar.sizeDelta = new Vector2(GetCurrentHealth(), healthBar.sizeDelta.y);
    }

}
