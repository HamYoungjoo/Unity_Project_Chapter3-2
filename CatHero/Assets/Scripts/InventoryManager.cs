using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public Transform slotParent;
    public GameObject ItemSlotPrefab;
    public Sprite[] itemSprites;

    private GameObject[] itemSlotBGs;
    private ItemEquip selectedItem; // 클릭한 아이템을 저장할 변수
    public GameObject ItemEquipPanel; // 장착 팝업 UI
    public GameObject ItemUnequipPanel; // 장착 해제 팝업 UI

    private void Start()
    {
        itemSlotBGs = new GameObject[9];
        for (int i = 0; i < 9; i++)
        {
            itemSlotBGs[i] = Instantiate(ItemSlotPrefab, slotParent);
        }

        for (int i = 0; i < itemSprites.Length; i++)
        {
            GameObject itemSlot = itemSlotBGs[i];
            ItemSlot slotScript = itemSlot.GetComponent<ItemSlot>();
            ItemEquip item = itemSlot.AddComponent<ItemEquip>();

            if (i < itemSprites.Length)
            {
                slotScript.SetItemIcon(itemSprites[i]);
            }
            else
            {
                slotScript.DisableIcon();
            }
        }
    }


    // 장착 확인 팝업에서 '확인' 버튼을 클릭할 때 호출되는 함수
    public void EquipItemConfirm()
    {
        if (selectedItem != null)
        {
            selectedItem.Equip();
            UpdateEquippedState(selectedItem, true);
        }
        ItemEquipPanel.SetActive(false);
    }

    public void UnequipItemConfirm()
    {
        if (selectedItem != null)
        {
            selectedItem.Unequip();
            // 아이템을 장착 해제한 상태에 따라 UI 업데이트 또는 이미지 표시를 처리
            // 예를 들어, 장착 중인 아이템의 체크 표시 이미지를 제거할 수 있습니다.
            UpdateEquippedState(selectedItem, false);
        }
        ItemUnequipPanel.SetActive(false);
    }

    // 장착 확인 팝업에서 '취소' 버튼을 클릭할 때 호출되는 함수
    public void CancelPanel()
    {
        ItemEquipPanel.SetActive(false);
        ItemUnequipPanel.SetActive(false);
    }

    private void UpdateEquippedState(ItemEquip item, bool isEquipped)
    {
        // 아이템 슬롯의 장착 표시 이미지 업데이트
        ItemSlot[] slots = slotParent.GetComponentsInChildren<ItemSlot>();
        foreach (var slot in slots)
        {
            if (slot.GetComponent<ItemEquip>() == item)
            {
                slot.SetEquipped(isEquipped);
                break;
            }
        }
    }
}
