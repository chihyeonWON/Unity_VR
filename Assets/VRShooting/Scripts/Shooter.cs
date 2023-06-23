using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab; // �Ѿ� ������
    [SerializeField] Transform gunBarrelEnd; // �ѱ�(�Ѿ��� �߻� ��ġ)

    [SerializeField] ParticleSystem gunParticle; // �߻� �� ����
    [SerializeField] AudioSource gunAudioSource; // �߻� �Ҹ��� ����

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

            // �߻� �� ������ ���
            gunParticle.Play();

            // �߻� ���� �Ҹ��� ���
            gunAudioSource.Play();
        }
    }
}
