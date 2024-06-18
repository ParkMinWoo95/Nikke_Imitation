using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Nikke Data", menuName = "Scriptable Object/Nikke Data", order = 0)]
public class NikkeBase : ScriptableObject
{
    [Header("���� �⺻ ����")]
    public string nikkeName = "����";
    public string nikkeDescription = "����";
    public Sprite nikkeIcon;
}
