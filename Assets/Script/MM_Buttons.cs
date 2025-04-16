using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MM_Buttons : MonoBehaviour
{
    [SerializeField] private GameObject _mainMenu;
    [SerializeField] private GameObject _error;

    public void FromMainMenu(GameObject fromObject)
    {
        _mainMenu.SetActive(false);
        fromObject.SetActive(true);
    }

    public void ToMainMenu(GameObject fromObject)
    {
        _mainMenu.SetActive(true);
        fromObject.SetActive(false);
    }

    public void ExitError()
    {
        _error.SetActive(false);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
