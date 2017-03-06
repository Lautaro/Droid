using UnityEngine;
using System.Collections;

public class DroidMachineGun : WeaponsBase
{
    Droid player;
    Animator animator;
    ParticleSystem attackEffect;
    public AudioClip MachineGunFire;
    public AudioClip MachineGunCoolDown;
    GameObject machineGun;
    bool firstShoot = true;
    public AudioSource machineGunAudio;

    void Awake()
    {
        machineGunAudio = gameObject.AddComponent<AudioSource>();
        if (machineGunAudio == null)
        {
            print("OMG IT`S NULL!");
        }
    }

    // Use this for initialization
    void Start()
    {

        player = ZoneScene.player;
        animator = player.GetComponent<Animator>();
        attackEffect = transform.SearchRecursively("AttackEffect").GetComponent<ParticleSystem>();
        machineGun = transform.SearchRecursively("MachineGun").gameObject;
        player.gui.SetMachinegunAmmo(Ammunition);
        

    }

    protected override void OnWeaponFired()
    {



        var rayDirection = machineGun.transform.TransformDirection(Vector2.up);
        var hits = Physics2D.RaycastAll(machineGun.transform.position, rayDirection, 50);
        Debug.DrawRay(machineGun.transform.position, rayDirection * 50, Color.white, 1);
        bool firstHit = false;
        foreach (var hit in hits)
        {

            TakeDamage creature = hit.collider.GetComponent<TakeDamage>();

            if (creature != null
                && creature.name != "Player"
                && !firstHit)
            {

                creature.MachineGunHit(transform.position);
                firstHit = true;
                break;
            }
        }



        //OverlapCircle = Get target that is within a circle. Like a mortar hit. 

        //				var objectsHit = Physics2D.OverlapCircleAll (Tools.GetMouseClickWorldPosition (), 1f);
        //		
        //				
        //				foreach (Collider2D target in objectsHit) {
        //									
        //						if (target.tag == "Creature") {
        //								var creature = target.GetComponent<TakeDamage> ();
        //								if (creature) {
        //										creature.MachineGunHit (player.transform.position);
        //								}													
        //						}						
        //				}				
    }

    // Update is called once per frame
    void Update()
    {
        if (state == WeaponState.firing)
        {


            if (firstShoot)
            {
                machineGunAudio.clip = MachineGunFire;
                machineGunAudio.Play();

                machineGunAudio.volume = 0.6f;
                machineGunAudio.loop = true;
                firstShoot = false;

            }

            animator.SetBool("IsShooting", true);
            animator.speed = 1;
            attackEffect.Play(true);
            player.IsShooting = true;


            var mouseClick = Tools.GetMouseClickWorldPosition();



        }
        else
        {

            if (player.IsShooting)
            {
                player.IsShooting = false;
                firstShoot = true;

                animator.SetBool("IsShooting", false);
                attackEffect.Stop(true);
                machineGunAudio.clip = MachineGunCoolDown;
                machineGunAudio.volume = 0.4f;
                machineGunAudio.Play();
                machineGunAudio.loop = false;
            }
        }

    }

    protected override void SpendAmmunition(int i)
    {
        base.SpendAmmunition(i);
        ZoneScene.player.gui.SetMachinegunAmmo(Ammunition);
    }


}
