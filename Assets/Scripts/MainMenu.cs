using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject lastMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeMenu(GameObject selectedMenu)
    {
        foreach (Transform menu in transform)
        {
            //check each menu and disable the active one
            if (menu.gameObject != selectedMenu && menu.gameObject.activeSelf)
            {
                menu.gameObject.SetActive(false);
                lastMenu = menu.gameObject;
            }
            //enable the menu that was selected to be shown
            else if (menu.gameObject == selectedMenu)
            {
                menu.gameObject.SetActive(true);
            }
        }

        //don't disable the background
        //if (selectedMenu != null)
        //{
        //    transform.Find("Background").gameObject.SetActive(true);
        //}
    }

    public void QuitApp()
    {
        Application.Quit();
    }
}
