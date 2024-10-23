using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject startPanel;
    [SerializeField] GameObject gamePanel;

    void ShowPanel(GameObject panel)
    {
        startPanel.SetActive(false);
        gameObject.SetActive(false);
        panel.SetActive(true);
    }
    public void OnClickStartButton()
    {
        ShowPanel(gamePanel);
        GameplayManager.instance.StartSpawningTargets();
    }
    
}
