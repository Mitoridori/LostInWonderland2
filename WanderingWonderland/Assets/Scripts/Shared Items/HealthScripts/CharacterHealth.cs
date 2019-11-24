using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterHealth : Health
{
    public int maxIconsPerRow = 5;

    private void OnGUI()
    {
        int icons = GetMaxHealth();
        Rect rect = new Rect(startPoint.x, startPoint.y, Screen.width - startPoint.x, Screen.height - startPoint.y);
        GUILayout.BeginArea(rect);
        do
        {
            GUILayout.BeginHorizontal();
            if (icons > maxIconsPerRow)
            {
                ImagesForInteger(maxIconsPerRow);
            }
            else
            {
                ImagesForInteger(icons);
            }

            GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();

            icons -= maxIconsPerRow;
        } while (icons > 0);

        GUILayout.EndArea();
    }

    private void ImagesForInteger(int total)
    {
        for (int i = 0; i < total; i++)
        {
            GUILayout.Label(icon);
        }
    }
}
