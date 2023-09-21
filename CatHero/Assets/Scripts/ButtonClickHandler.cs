using UnityEngine;
using UnityEngine.UI;

public class ButtonClickHandler : MonoBehaviour
{
    public InventoryManager inventoryManager; 
    public void EquipItem()
    {
        inventoryManager.EquipItemConfirm(); 
    }

    public void UnequipItem()
    {
        inventoryManager.UnequipItemConfirm();
    }

    public void CancelPanel()
    {
        inventoryManager.CancelPanel(); 
    }
}
