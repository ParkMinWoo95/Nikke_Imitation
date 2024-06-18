using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Nikke Data", menuName = "Scriptable Object/Nikke Data", order = 0)]
public class NikkeBase : ScriptableObject
{
    [Header("니케 기본 정보")]
    public string nikkeName = "니케";
    public string nikkeDescription = "설명";
    public Sprite nikkeIcon;
}
