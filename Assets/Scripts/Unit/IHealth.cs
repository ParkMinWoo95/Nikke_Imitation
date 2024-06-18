using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHealth
{
    /// <summary>
    /// MP Ȯ�� �� ������ ������Ƽ
    /// </summary>
    float HP { get; set; }

    /// <summary>
    /// �ִ� HPȮ�ο� ������Ƽ
    /// </summary>
    float MaxHP { get; }

    /// <summary>
    /// HP�� ����� ������ ����� ��������Ʈ(float:����)�� ������Ƽ
    /// </summary>
    Action<float> onHealthChange { get; set; }

    /// <summary>
    /// ������ Ȯ���ϱ� ���� ������Ƽ
    /// </summary>
    bool IsAlive { get; }

    /// <summary>
    /// ��� ó���� �Լ�(�޼��� method)
    /// </summary>
    void Die();

    /// <summary>
    /// ����� �˸��� ���� ��������Ʈ�� ������Ƽ
    /// </summary>
    Action onDie { get; set; }
}
