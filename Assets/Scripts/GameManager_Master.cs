using UnityEngine;
using System.Collections;

public class GameManager_Master : MonoBehaviour
{
    public delegate void GameManagerEventHandler();
    public event GameManagerEventHandler MenuToggleEvent;
    public event GameManagerEventHandler InventoryUIToggleEvent;
    public event GameManagerEventHandler RestartLevelEvent;
    public event GameManagerEventHandler GoToMenuSceneEvent;
    public event GameManagerEventHandler GameOverEvent;

    public bool isGameOver;
    public bool isInventoryUIOn;
    public bool isMenuOn;

    public void CallEventMenuToggle()
    {
        MenuToggleEvent?.Invoke();
    }

    public void CallEventInventoryUIToggle()
    {
        InventoryUIToggleEvent?.Invoke();
    }

    public void CallEventRestartLevel()
    {
        RestartLevelEvent?.Invoke();
    }

    public void CallEventGoToMenuScene()
    {
        GoToMenuSceneEvent?.Invoke();
    }

    public void CallEventGameOver()
    {
        GameOverEvent?.Invoke();
    }
}
