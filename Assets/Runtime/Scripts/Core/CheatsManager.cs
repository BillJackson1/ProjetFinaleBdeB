using UnityEngine;
using UnityEngine.InputSystem;
using Final_Survivors.Player;
using Final_Survivors.Weapons;
using Final_Survivors.UI.Intro;
using TMPro;
using Final_Survivors.Environment;

namespace Final_Survivors.Core
{
    public class CheatsManager : MonoBehaviour
    {
        [Header("Cheats Menu")]
        [SerializeField] private GameObject cheatsMenu;

        [Header("God Mode")]
        [SerializeField] private TextMeshProUGUI godModeState;

        [Header("Infinite Time Warp")]
        [SerializeField] private TextMeshProUGUI infiniteTimeWarpState;

        [Header("References")]
        [SerializeField] private GameObject Background;
        [SerializeField] private GameObject CheatsText;
        [SerializeField] private GameObject Buttons;
        [SerializeField] private CursorManager cursorManager; // Reference to CursorManager.cs

        // TELEPORT POSITIONS
        private Vector3 southWest = new Vector3(-35.1899986f, -5.0f, -39.9900017f);
        private Vector3 southEast = new Vector3(20f, -5f, -52.3600006f);
        private Vector3 northWest = new Vector3(-46.4749985f, -5.0f, 57.3720016f);
        private Vector3 northEast = new Vector3(12.9200001f, -5.0f, 56.9900017f);

        // CHEATS RELATED STUFF
        private GameObject player;
        private PlayerManager playerManager;
        private PlayerController playerController;
        private SpawnManager spawnManager;
        private Weapon weaponScript;
        
        // Player Input
        private PlayerInput playerInput;
        private InputAction showHideCheatsMenuAction;

        private void Start()
        {
            player = GameObject.FindGameObjectWithTag("Player");
            playerManager = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerManager>();
            playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
            spawnManager = GameObject.FindGameObjectWithTag("SpawnManager").GetComponent <SpawnManager>();
            playerInput = GetComponent<PlayerInput>();
            showHideCheatsMenuAction = playerInput.actions["Show or Hide Cheats Menu"];
        }
        
        private void Update()
        {
            if(!EnvironmentState.GetIsIntroduction())
            {
                if (cheatsMenu.activeSelf == false && showHideCheatsMenuAction.triggered)
                {
                    OpenCheatsMenu();
                }
                else if (cheatsMenu.activeSelf == true && showHideCheatsMenuAction.triggered)
                {
                    CloseCheatsMenu();
                    Resume();
                }
            }
        }

        // OPEN/CLOSE CHEAT MENU
        private void OpenCheatsMenu()
        {
            // Pause the game
            Time.timeScale = 0f; // Pause the game
            cursorManager.IsPausedCursor = true;

            // Show the cheats menu
            cheatsMenu.SetActive(true);

            // Hide some UI elements
            Background.SetActive(false);
            CheatsText.SetActive(false);
            Buttons.SetActive(false);
        }

        private void CloseCheatsMenu()
        {
            // Resume the game
            Time.timeScale = 1f; // Resume the game
            cursorManager.IsPausedCursor = false;

            // Hide the cheats menu
            cheatsMenu.SetActive(false);

            // Restore/show some UI elements
            Background.SetActive(true);
            CheatsText.SetActive(true);
            Buttons.SetActive(true);
        }

        private void Resume()
        {
            Time.timeScale = 1f; // Resume the game
            cursorManager.IsPausedCursor = false;
        }
        
        // DEV
        public void GodMode()
        {
            playerManager.SetInvulnerability(!playerManager.GetInvulnerability());
            playerManager.SetIsGodMode(!playerManager.GetIsGodMode());

            if (playerManager.GetIsGodMode())
            {
                godModeState.text = "God Mode ON";
            }
            else
            {
                godModeState.text = "God Mode OFF";
            }
        }

        // SPAWN
        public void PauseSpawn()
        {
            spawnManager.PauseSpawn();
        }

        public void ResumeSpawn()
        {
            spawnManager.PlaySpawn();
        }

        public void DecreaseDifficulty()
        {
            if (spawnManager.Level > 1)
            {
                --spawnManager.Level;
            }
        }

        public void IncreaseDifficulty()
        {
            ++spawnManager.Level;
        }

        // WEAPONS
        public void Shotgun()
        {
            playerController.RandomPickWeapon(WeaponType.SHOTGUN);
        }

        public void MachineGun()
        {
            playerController.RandomPickWeapon(WeaponType.MACHINEGUN);
        }

        public void Sniper()
        {
            playerController.RandomPickWeapon(WeaponType.SNIPER);
        }

        public void RocketLauncher()
        {
            playerController.RandomPickWeapon(WeaponType.ROCKET_LAUNCHER);
        }

        // SWORD
        public void MaxSwordDamage()
        {
            playerController.GetSword().GetComponent<Sword>().NewDmg(50000);
        }

        public void DefaultSwordDamage()
        {
            playerController.GetSword().GetComponent<Sword>().NewDmg(600);
        }

        // TELEPORT
        public void TP_SouthWest()
        {
            player.transform.position = southWest;
        }

        public void TP_SouthEast()
        {
            player.transform.position = southEast;
        }

        public void TP_NorthWest()
        {
            player.transform.position = northWest;
        }

        public void TP_NorthEast()
        {
            player.transform.position = northEast;
        }
        
        // REFILL
        public void AmmoRefill()
        {
            weaponScript = playerController.selectedWeapon.GetComponent<Weapon>();
            weaponScript.RefillAmmo();
        }

        public void TimewarpRefill()
        {
            playerController.RefillTimeWarp();
        }

        public void TimewarpInfinite()
        {
            if (!playerController.isInfiniteTimeWarp)
            {
                infiniteTimeWarpState.text = "Infinite ON";
                TimewarpRefill();
                playerController.isInfiniteTimeWarp = true;
            }
            else
            {
                infiniteTimeWarpState.text = "Infinite OFF";
                playerController.isInfiniteTimeWarp = false;
            }
        }

        // SPAWN BOSS
        public void DragonBoss()
        {
            spawnManager.SpawnBoss(0);
        }

        public void SpiderBoss()
        {
            spawnManager.SpawnBoss(4);
        }

        public void RazorBoss()
        {
            spawnManager.SpawnBoss(2);
        }

        public void NoseBoss()
        {
            spawnManager.SpawnBoss(1);
            
        }

        public void RobotBoss()
        {
            spawnManager.SpawnBoss(3);
            
        }

        // SPAWN ELITE
        public void DragonElite()
        {
            spawnManager.SpawnElite(0);
        }

        public void SpiderElite()
        {
            spawnManager.SpawnElite(4);
        }

        public void RazorElite()
        {
            spawnManager.SpawnElite(2);
        }

        public void NoseElite()
        {
            spawnManager.SpawnElite(1);
        }

        public void RobotElite()
        {
            spawnManager.SpawnElite(3);
        }
    }
}
