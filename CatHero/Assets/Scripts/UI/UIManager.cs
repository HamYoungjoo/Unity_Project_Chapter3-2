using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject StatusPanel; 
    public GameObject InventoryPanel; 
    public Button BackButton;
    public Button StatusButton;
    public Button InventoryButton;


    private void Start()
    {
        //BackButton.gameObject.SetActive(false);
        //StatusPanel.SetActive(false);
        //InventoryPanel.SetActive(false);
    }

    public void ShowCharacterInfo()
    {
        StatusPanel.SetActive(true);
        BackButton.gameObject.SetActive(true);

        StatusButton.gameObject.SetActive(false);
        StatusButton.interactable = false;
        InventoryButton.gameObject.SetActive(false);
        InventoryButton.interactable = false;
    }

    public void ShowInventory()
    {
        InventoryPanel.SetActive(true);
        BackButton.gameObject.SetActive(true);

        StatusButton.gameObject.SetActive(false);
        StatusButton.interactable = false;
        InventoryButton.gameObject.SetActive(false);
        InventoryButton.interactable = false;
    }

    public void GoBack()
    {

        StatusPanel.SetActive(false);
        InventoryPanel.SetActive(false);
        BackButton.gameObject.SetActive(false);

        StatusButton.gameObject.SetActive(true);
        StatusButton.interactable = true;
        InventoryButton.gameObject.SetActive(true);
        InventoryButton.interactable = true;
    }
}
