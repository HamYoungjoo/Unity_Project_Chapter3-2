using UnityEngine;
using UnityEngine.UI;

public class ButtonClickHandler : MonoBehaviour
{
    public InventoryManager inventoryManager; // InventoryManager 참조를 설정하기 위한 변수

    public void EquipItem()
    {
        inventoryManager.EquipItemConfirm(); // InventoryManager의 EquipItemConfirm 메서드 호출
    }

    public void UnequipItem()
    {
        inventoryManager.UnequipItemConfirm(); // InventoryManager의 UnequipItemConfirm 메서드 호출
    }

    public void CancelPanel()
    {
        inventoryManager.CancelPanel(); // InventoryManager의 CancelPanel 메서드 호출
    }
}
