using UnityEngine;

public class ItemEquip : MonoBehaviour
{
    private bool isEquipped = false; // 아이템 장착 상태

    public bool IsEquipped
    {
        get { return isEquipped; }
    }

    // 아이템 장착 상태 설정
    public void SetEquipped(bool equipped)
    {
        isEquipped = equipped;
    }
}
