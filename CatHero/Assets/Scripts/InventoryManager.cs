using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public Transform slotParent; 
    public GameObject ItemSlotBGPrefab; 
    public GameObject IconPrefab;
    public Sprite[] itemSprites; 

    private void Start()
    {
        for (int j = 0; j < 9;j++)
        {
            GameObject itemSlotBG = Instantiate(ItemSlotBGPrefab, slotParent);

        }

        for (int i = 0; i < itemSprites.Length; i++)
        {
            GameObject IconImg = Instantiate(IconPrefab, slotParent);
            Image slotImage = IconImg.GetComponentInChildren<Image>(); // 슬롯 하위의 Image 컴포넌트를 찾음
            slotImage.sprite = itemSprites[i]; // 이미지 설정
        }
    }
}
