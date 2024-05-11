using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Transform pos;
    [SerializeField] private double speed;
    [SerializeField] private Vector3 direction;

    [SerializeField] private double maxLifetime;
    [SerializeField] private double remainingLifetime;

    public GameObject owner;
    public List<BulletModifier> activeMods = new();
    public List<BulletModifier> allMods = new();

    // Start is called before the first frame update
    void Start()
    {
        pos = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
