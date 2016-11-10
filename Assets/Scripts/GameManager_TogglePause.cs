using UnityEngine;
using System.Collections;

public class GameManager_TogglePause : MonoBehaviour {
    private GameManager_Master gameManagerMaster;
    private bool isPaused;

    void OnEnable()
    {
        SetInitialReferences();
        gameManagerMaster.MenuToggleEvent += TogglePause;
        gameManagerMaster.InventoryUIToggleEvent += TogglePause;
    }

    void OnDisable()
    {
        gameManagerMaster.MenuToggleEvent -= TogglePause;
        gameManagerMaster.InventoryUIToggleEvent -= TogglePause;
    }

    void SetInitialReferences()
    {
        gameManagerMaster = GetComponent<GameManager_Master>();
    }

    void TogglePause()
    {
        if (isPaused)
        {
            Time.timeScale = 1;
            isPaused = true;
        }
        else
        {
            Time.timeScale = 0;
            isPaused = false;
        }
    }
}
