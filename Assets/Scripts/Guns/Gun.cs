using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [Header("Weapon Stats")]
    [SerializeField] LayerMask _layerMask;
    [SerializeField] float _damage;
    [SerializeField] float _fireRate;

    [Header("VFX")]
    [SerializeField] private GameObject _muzzleFlashPrefab;
    [SerializeField] private GameObject _firePoint;
    private GameObject _bin;

    [Header("Audio")]
    [SerializeField] private AudioClip _gunSound;
    [SerializeField] private AudioSource _audioSource;

    private float _nextFireTime = 0f;

    private void Start()
    {
        _bin = GameObject.FindGameObjectWithTag("Bin");
        if (_bin == null)
            Debug.LogError("Can't find bin");
    }

    public void Fire()
    {
        if(Time.time > _nextFireTime)
        {
            GameObject muzzleFlash = Instantiate(_muzzleFlashPrefab, _firePoint.transform.position, _firePoint.transform.rotation, _bin.transform);
            Destroy(muzzleFlash, 0.1f);
            _nextFireTime = Time.time + _fireRate;
        }        
    }
}
