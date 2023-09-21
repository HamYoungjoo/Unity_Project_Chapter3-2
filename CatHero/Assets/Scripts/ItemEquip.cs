using UnityEngine;

public class ItemEquip : MonoBehaviour
{
    public bool isEquipped = false; // 장착 여부

    public void Equip()
    {
        isEquipped = true;
    }

    public void Unequip()
    {
        isEquipped = false;
    }
}
