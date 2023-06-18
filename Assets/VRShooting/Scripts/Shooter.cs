using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotter : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab; // �Ѿ� ������
    [SerializeField] Transform gunBarrelEnd; // �ѱ�(�Ѿ��� �߻� ��ġ)

    // Update is called once per frame
    void Update()
    {
        // �Է¿� ���� �Ѿ��� �߻��Ѵ�.
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }

        void Shoot()
        {
            // �������� �������� ���� �Ѿ��� ����
            Instantiate(bulletPrefab, gunBarrelEnd.position, gunBarrelEnd.rotation);
        }
    }
}
