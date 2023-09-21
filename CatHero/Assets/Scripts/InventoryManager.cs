using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public Transform slotParent; // 슬롯 부모 객체
    public GameObject ItemSlotPrefab; // 아이템 슬롯 프리팹
    public Sprite[] itemSprites; // 아이템 스프라이트 배열

    private void Start()
    {
        // 아이템 슬롯 배치
        for (int i = 0; i < 9; i++)
        {
            GameObject itemSlot = Instantiate(ItemSlotPrefab, slotParent);
            ItemSlot slotScript = itemSlot.GetComponent<ItemSlot>();

            if (i < itemSprites.Length)
            {
                // 아이콘 이미지 설정
                slotScript.SetItemIcon(itemSprites[i]);
            }
            else
            {
                // 아이템이 없으면 아이콘 이미지를 비활성화
                slotScript.DisableIcon();
            }
        }
    }
}
