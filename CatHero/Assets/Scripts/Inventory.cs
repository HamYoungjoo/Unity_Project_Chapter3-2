using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Inventory : MonoBehaviour
{
    public Image[] itemImages; 
    public Sprite[] itemSprites; 

    private int equippedItemIndex = -1; // 현재 장착한 아이템의 인덱스 (-1은 장착된 아이템이 없음을 나타냄)

    private void Start()
    {
        itemImages = new Image[itemSprites.Length];

        for (int i = 0; i < itemSprites.Length; i++)
        {
            GameObject itemObject = new GameObject("Item" + i.ToString()); // 아이템 이미지를 위한 게임 오브젝트 생성
            itemImages[i] = itemObject.AddComponent<Image>(); // 이미지 컴포넌트 추가
            itemImages[i].sprite = itemSprites[i]; // 이미지 스프라이트 설정

            itemObject.transform.SetParent(transform);
            itemObject.SetActive(false); // 초기에는 비활성화
        }
    }

    public void EquipItem(int itemIndex)
    {
        // 이전에 장착한 아이템을 비활성화
        if (equippedItemIndex >= 0)
        {
            itemImages[equippedItemIndex].gameObject.SetActive(false);
        }

        // 선택한 아이템을 장착
        equippedItemIndex = itemIndex;
        itemImages[equippedItemIndex].gameObject.SetActive(true);
    }

    public void UnequipItem()
    {
        // 현재 장착한 아이템을 해제
        if (equippedItemIndex >= 0)
        {
            itemImages[equippedItemIndex].gameObject.SetActive(false);
            equippedItemIndex = -1; // 장착 아이템 없음으로 설정
        }
    }
}

