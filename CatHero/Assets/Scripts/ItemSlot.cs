using UnityEngine;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour
{
    public Image iconImage; // 아이콘 이미지를 표시할 Image 컴포넌트
    public Image equippedImage; // 장착 표시 이미지

    public void SetItemIcon(Sprite sprite)
    {
        // 아이콘 이미지를 활성화하고 스프라이트 설정
        iconImage.enabled = true;
        iconImage.sprite = sprite;

        // 클릭 이벤트 리스너 추가
        Button iconButton = iconImage.GetComponent<Button>();
        iconButton.onClick.AddListener(OnIconClick);
    }

    public void DisableIcon()
    {
        // 아이콘 이미지를 비활성화
        iconImage.enabled = false;
    }

    public void SetEquipped(bool isEquipped)
    {
        // 장착 표시 이미지를 활성화 또는 비활성화
        equippedImage.gameObject.SetActive(isEquipped);
    }

    // 아이콘 클릭 시 호출되는 함수
    private void OnIconClick()
    {
        // 클릭한 아이템 정보를 얻어올 수 있도록 수정
        ItemEquip item = GetComponent<ItemEquip>();
        InventoryManager inventoryManager = FindObjectOfType<InventoryManager>();

        if (item.isEquipped)
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
