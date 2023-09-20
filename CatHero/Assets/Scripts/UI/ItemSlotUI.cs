using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSlotUI : MonoBehaviour
{
    public Transform slotParent; // 슬롯들이 자식으로 들어갈 부모 Transform
    public GameObject itemSlotPrefab; // 아이템 슬롯 프리팹
    public Sprite[] itemSprites; // 아이템 스프라이트 배열

    private void Start()
    {
        // 각각의 아이템 슬롯을 생성하고 이미지 설정
        for (int i = 0; i < itemSprites.Length; i++)
        {
            GameObject itemSlot = Instantiate(itemSlotPrefab, slotParent);
            Image slotImage = itemSlot.GetComponentInChildren<Image>(); // 슬롯 하위의 Image 컴포넌트를 찾음
            slotImage.sprite = itemSprites[i]; // 이미지 설정
        }
    }
}
