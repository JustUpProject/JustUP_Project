using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlidingPartical : MonoBehaviour
{
    BasicControler player;

    public GameObject particle;
    public bool isParticleCycle = false;

    private float setParticleTime = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("IsParticle", 0.0f, setParticleTime);
        player = GetComponent<BasicControler>();
        //player = FindObjectOfType<Basic_Character>();
    }

   
    private void IsParticle()
    {
        isParticleCycle = true;
    }

    public void SpwanParticle()
    {
        isParticleCycle = false;
        GameObject particleObject = Instantiate(particle, this.transform.position, this.transform.rotation);
        Destroy(particleObject, 3);
    }
}
