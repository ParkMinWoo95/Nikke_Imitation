using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHealth
{
    /// <summary>
    /// MP 확인 및 설정용 프로퍼티
    /// </summary>
    float HP { get; set; }

    /// <summary>
    /// 최대 HP확인용 프로퍼티
    /// </summary>
    float MaxHP { get; }

    /// <summary>
    /// HP가 변경될 때마다 실행될 델리게이트(float:비율)용 프로퍼티
    /// </summary>
    Action<float> onHealthChange { get; set; }

    /// <summary>
    /// 생존을 확인하기 위한 프로퍼티
    /// </summary>
    bool IsAlive { get; }

    /// <summary>
    /// 사망 처리용 함수(메서드 method)
    /// </summary>
    void Die();

    /// <summary>
    /// 사망을 알리기 위한 델리게이트용 프로퍼티
    /// </summary>
    Action onDie { get; set; }
}
