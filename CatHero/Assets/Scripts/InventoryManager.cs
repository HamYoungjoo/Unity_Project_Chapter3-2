using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public Transform slotParent;
    public GameObject ItemSlotPrefab;
    public Sprite[] itemSprites;

    private GameObject[] itemSlotBGs;
    //private ItemEquip selectedItem; // 클릭한 아이템을 저장할 변수
    public GameObject ItemEquipPanel; // 장착 팝업 UI
    public GameObject ItemUnequipPanel; // 장착 해제 팝업 UI


    public Image EquippedImage;

    private bool isImageActive = false;

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

    public void ShowPanel()
    {

        if(EquippedImage != null)
        {
            ItemUnequipPanel.SetActive(true);
        }
        else
        {
            ItemEquipPanel.SetActive(true);
        }

    }
    

    public void EquipItemConfirm()
    {
        EquippedImage.gameObject.SetActive(true);
     
        ItemEquipPanel.SetActive(false);
    }

    public void UnequipItemConfirm()
    {
        EquippedImage.gameObject.SetActive(false);
        ItemUnequipPanel.SetActive(false);
    }

    public void CancelPanel()
    {
        ItemEquipPanel.SetActive(false);
        ItemUnequipPanel.SetActive(false);
    }

    //private void UpdateEquippedState(ItemEquip item, bool isEquipped)
    //{
    //    ItemSlot[] slots = slotParent.GetComponentsInChildren<ItemSlot>();
    //    foreach (var slot in slots)
    //    {
    //        if (slot.GetComponent<ItemEquip>() == item)
    //        {
    //            slot.SetEquipped(isEquipped);
    //            break;
    //        }
    //    }
    //}
}
