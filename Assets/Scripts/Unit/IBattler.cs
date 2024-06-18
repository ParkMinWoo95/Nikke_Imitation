using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBattler
{
    /// <summary>
    /// �� ������Ʈ�� Ʈ������
    /// </summary>
    Transform transform { get; }

    /// <summary>
    /// ���ݷ� Ȯ�ο� ������Ƽ
    /// </summary>
    float AttackPower { get; }

    /// <summary>
    /// ���� Ȯ�ο� ������Ƽ
    /// </summary>
    float DefencePower { get; }

    /// <summary>
    /// �¾��� �� ����� ��������Ʈ(int:������ ���� ������)
    /// </summary>
    Action<int> onHit { get; set; }

    /// <summary>
    /// ���� �Լ�
    /// </summary>
    /// <param name="target">���� ������ ���</param>
    void Attack(IBattler target);

    /// <summary>
    /// ��� �Լ�
    /// </summary>
    /// <param name="damage">���� ���� ������</param>
    void Defence(float damage);
}
