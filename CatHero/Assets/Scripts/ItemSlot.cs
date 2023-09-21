using UnityEngine;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour
{
    public Image iconImage; 
    public Image equippedImage; 

    public void SetItemIcon(Sprite sprite)
    {
        iconImage.enabled = true;
        iconImage.sprite = sprite;

        Button iconButton = iconImage.GetComponent<Button>();
        iconButton.onClick.AddListener(OnIconClick);
    }

    public void DisableIcon()
    {
        iconImage.enabled = false;
    }

    public void SetEquipped(bool isEquipped)
    {
        equippedImage.gameObject.SetActive(isEquipped);
    }

    private void OnIconClick()
    {
        ItemEquip item = GetComponent<ItemEquip>();
        InventoryManager inventoryManager = FindObjectOfType<InventoryManager>();

        if (item.IsEquipped)
        {
            // 이미 장착 중인 아이템을 클릭하면 해제 확인 팝업을 표시
            inventoryManager.ItemUnequipPanel.SetActive(true);
        }
        else
        {
            // 아이템을 클릭하면 장착 확인 팝업을 표시
            inventoryManager.ItemEquipPanel.SetActive(true);
        }
    }
}
