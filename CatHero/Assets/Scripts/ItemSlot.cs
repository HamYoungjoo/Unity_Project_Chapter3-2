using UnityEngine;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour
{
    public Image iconImage; // 아이콘 이미지를 표시할 Image 컴포넌트

    public void SetItemIcon(Sprite sprite)
    {
        // 아이콘 이미지를 활성화하고 스프라이트 설정
        iconImage.enabled = true;
        iconImage.sprite = sprite;
    }

    public void DisableIcon()
    {
        // 아이콘 이미지를 비활성화
        iconImage.enabled = false;
    }
}
