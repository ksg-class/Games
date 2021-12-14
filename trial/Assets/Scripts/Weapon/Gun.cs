using UnityEngine;
using System.Collections.Generic;
using System.Collections;

namespace Alpha
{
    public class Gun : MonoBehaviour
    {
        #region Variables
        [Header("Gun Properites")]
        public GameObject muzzlePoint;
        [SerializeField]
        private Transform player;

        //bullet 
        public GameObject bullet;
        public bool useBullet = true;
        public bool useRayCastToDamage = true;
        [Header("Audio")]
        public AudioSource shootAudio;
        public AudioSource reloadAudio;

        //Gun stats
        [Header("Gun Stats")]
        public float gunDamage = 20f;
        public float bulletForce = 10f;
        public float gunRange = 2f;
        public float timeBetweenShooting, reloadTime, timeBetweenShots;
        public int magazineSize, bulletsPerTap;
        public bool allowButtonHold;
        public LayerMask enemyLayer;

        public bool allowInvoke = true;

        //Graphics
        [Header("Graphics")]
        public GameObject muzzleFlash;
        public LineRenderer laserLight;


        public bool useDebug = false;
        int bulletsLeft, bulletsShot;

        //bools
        bool shooting, readyToShoot, reloading;
        public bool isShooting=false;

        public float shootTimer = 1f;
        private float counter = 0;

        private bool useLaserLight = true;
        private float effectsDisplayTime = 0.5f;
        private float timer;
        private ParticleSystem flash;
        private LineRenderer gunRenderer;
        private GameObject muzzleFlashInstance;
        private RaycastHit hit;
        private InputManager inputManager;
        private Ray ray;

        public bool Reloading { get { return reloading; } }
        public bool IsShooting { get { return isShooting; } }
        #endregion

        #region Builtin Methods
        private void Awake()
        {
            //make sure magazine is full
            bulletsLeft = magazineSize;
            readyToShoot = true;
            gunRenderer = GetComponentInChildren<LineRenderer>();
            muzzleFlashInstance = Instantiate(muzzleFlash, transform);
            flash = muzzleFlashInstance.GetComponent<ParticleSystem>();
            inputManager = transform.root.GetComponent<InputManager>();
        }
        private void Update()
        {
            timer += Time.deltaTime;
            GetInput();
            LaserLight();
            if (timer >= timeBetweenShooting * effectsDisplayTime)
            {
                gunRenderer.enabled = false;
            }

            counter += Time.deltaTime;

            if (counter > shootTimer)
            {
                isShooting = false;
            }
        }

        void OnDrawGizmos()
        {
            if (useDebug)
            {
                Gizmos.color = Color.green;
                Gizmos.DrawLine(muzzleFlash.transform.localPosition, player.transform.forward * gunRange);
                //Gizmos.DrawRay(ray);
            }
        }
        #endregion

        #region Custom Methods

        private void GetInput()
        {
            //Check if allowed to hold down button and take corresponding input
            if (allowButtonHold) shooting = inputManager.Shoot;
            else shooting = inputManager.Shoot;

            //Reloading 
            if (inputManager.Reload && bulletsLeft < magazineSize && !reloading)
            {
               
                Reload();
            }
            //Reload automatically when trying to shoot without ammo
            if (readyToShoot && shooting && !reloading && bulletsLeft <= 0)
            {
                
                Reload();
            }

            //Shooting
            if (readyToShoot && shooting && !reloading && bulletsLeft > 0)
            {
                //Set bullets shot to 0
                bulletsShot = 0;
                isShooting = true;
                useLaserLight = false;
                counter = 0;
                Shoot();
            }
            else
            {
                //isShooting = false;
                useLaserLight = true;

            }

        }
        void Shoot()
        {
            readyToShoot = false;
            timer = 0;
            isShooting = true;
            // ray = new Ray(muzzlePoint.transform.position, player.transform.forward);

            //Audio
            shootAudio.Stop();
            shootAudio.Play();

            gunRenderer.enabled = true;
            gunRenderer.SetPosition(0, muzzlePoint.transform.position);
            if (DidRayCastHit())
            {
                
                gunRenderer.SetPosition(1, hit.point);
                
                if (useRayCastToDamage)
                {
                    DealDamage();
                }

            }
            else
            {
                
                gunRenderer.SetPosition(1, ray.origin + ray.direction * gunRange);
            }


            if (useBullet)
            {
                //Instantiate bullet/projectile
                GameObject currentBullet = Instantiate(bullet, muzzlePoint.transform.position, Quaternion.identity); //store instantiated bullet in currentBullet
                currentBullet.GetComponent<Bullet>().ApplyForce(player.transform.forward);
            }


            //Instantiate muzzle flash, if you have one
            if (muzzleFlash != null)
            {
                muzzleFlashInstance.transform.position = muzzlePoint.transform.position;
                flash.Play();
            }


            bulletsLeft--;
            bulletsShot++;

            //Invoke resetShot function (if not already invoked), with your timeBetweenShooting
            if (allowInvoke)
            {
                Invoke("ResetShot", timeBetweenShooting);
                allowInvoke = false;
            }

            //if more than one bulletsPerTap make sure to repeat shoot function
            if (bulletsShot < bulletsPerTap && bulletsLeft > 0)
                Invoke("Shoot", timeBetweenShots);
        }

        void ResetShot()
        {
            //Allow shooting and invoking again
            readyToShoot = true;
            allowInvoke = true;
        }

        void Reload()
        {
            counter = 0;
            useLaserLight = false;
            reloading = true;
            Invoke("ReloadFinished", reloadTime); //Invoke ReloadFinished function with your reloadTime as delay
            reloadAudio.Play();
            isShooting = false;
        }

        void ReloadFinished()
        {

            bulletsLeft = magazineSize;
            reloading = false;
            reloadAudio.Stop();
            useLaserLight = true;
        }
        
        
        void LaserLight()
        {
            if(useLaserLight)
            {
                laserLight.enabled = true;
                laserLight.SetPosition(0, muzzlePoint.transform.position);
                if (DidRayCastHit())
                {
                    laserLight.SetPosition(1, hit.point);
                }
                else
                {
                    laserLight.SetPosition(1, ray.origin + ray.direction * gunRange);
                }
            }
            else
            {
                laserLight.enabled = false;
            }
        }

        bool DidRayCastHit()
        {
            ray = new Ray(muzzlePoint.transform.position, player.transform.forward);
            if (Physics.Raycast(ray, out hit, gunRange, enemyLayer.value,QueryTriggerInteraction.Ignore))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        void DealDamage()
        {
            HealthManager healthManager = hit.transform.GetComponent<HealthManager>();
            
            if(healthManager)
            {
                healthManager.TakeDamage(gunDamage, hit.normal,hit.point, bulletForce);
            }

        }



        #endregion
    }
}
