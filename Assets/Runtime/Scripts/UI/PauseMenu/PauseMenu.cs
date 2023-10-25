using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using TMPro;
using Final_Survivors.Core;
using Final_Survivors.Environment;

namespace Final_Survivors.UI.PauseMenu
{
    public class PauseMenu : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private GameObject pauseMenu;
        [SerializeField] private GameObject pauseMenuButtons; 
        [SerializeField] private GameObject HUD;
        [SerializeField] private CursorManager cursorManager; // Reference to CursorManager.cs

        private TextMeshProUGUI mainTitle;

        // Player Input
        private PlayerInput playerInput;
        private InputAction showHideMenuAction;

        // NEW OPTIONS MENU REFERENCES
        [Header("New Options Menu References")]
        [SerializeField] private GameObject optionsMenu; // default tab is "Audio" menu
        [SerializeField] private GameObject controlsMenu;
        [SerializeField] private GameObject difficultyMenu;
        [SerializeField] private GameObject cheatsMenu;

        // Difficulty Menu References (special case)
        [Header("Difficulty Menu References")]
        [SerializeField] private GameObject difficultyMenuButtons;

        [Header("Cheats Menu References")]
        [SerializeField] private GameObject Background;
        [SerializeField] private GameObject CheatsText;
        [SerializeField] private GameObject Buttons;

        private void Awake()
        {
            playerInput = GetComponent<PlayerInput>();
            showHideMenuAction = playerInput.actions["Show or Hide Menu"];
        }

        private void Update()
        {
            if (pauseMenu.activeSelf == false && showHideMenuAction.triggered)
            {
                Pause(); // open the pause menu
            }
            else if (pauseMenu.activeSelf == true && showHideMenuAction.triggered)
            {
                if (optionsMenu.activeSelf == false)
                {
                    Resume(); // close the pause menu
                }
                else if (optionsMenu.activeSelf == true)
                {
                    BackToPauseMenu(); // return to the pause menu
                }
            }
        }

        public void Pause()
        {
            if (!EnvironmentState.GetIsIntroduction())
            {
                Time.timeScale = 0f; // Pause the game
                cursorManager.IsPausedCursor = true;
                HUD.SetActive(false);

                // Hide cheats menu if open
                cheatsMenu.SetActive(false);
                Background.SetActive(true);
                CheatsText.SetActive(true);
                Buttons.SetActive(true);

                pauseMenuButtons.SetActive(true);
                pauseMenu.SetActive(true);
                EnvironmentState.SetIsPause(true);

                mainTitle = GameObject.Find("Text/Logo").GetComponent<TextMeshProUGUI>();
                mainTitle.outlineWidth = 0.1f;
                mainTitle.outlineColor = Color.black;
            }
        }

        public void Resume()
        {
            Time.timeScale = 1f; // Resume the game
            cursorManager.IsPausedCursor = false;
            HUD.SetActive(true);
            optionsMenu.SetActive(false);
            pauseMenu.SetActive(false);
            EnvironmentState.SetIsPause(false);
        }

        public void ReturnToMainMenu()
        {
            Time.timeScale = 1f; // Resume the game
            SceneManager.LoadSceneAsync("00_MainMenu");
        }

        public void Quit()
        {
            #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
            #else
                Application.Quit();
            #endif
        }

        // NEW OPTIONS MENU FUNCTIONS

        public void Options() // Audio is the default tab
        {
            optionsMenu.SetActive(true); // default tab is "Audio" menu
            controlsMenu.SetActive(false);
            difficultyMenu.SetActive(false);
            cheatsMenu.SetActive(false);
            difficultyMenuButtons.SetActive(false);
        }

        public void Controls()
        {
            optionsMenu.SetActive(false);
            controlsMenu.SetActive(true);
            difficultyMenu.SetActive(false);
            cheatsMenu.SetActive(false);
            difficultyMenuButtons.SetActive(false);
        }

        public void Difficulty()
        {
            optionsMenu.SetActive(false);
            controlsMenu.SetActive(false);
            difficultyMenu.SetActive(true);
            cheatsMenu.SetActive(false);
            difficultyMenuButtons.SetActive(true);
        }

        public void Cheats()
        {
            optionsMenu.SetActive(false);
            controlsMenu.SetActive(false);
            difficultyMenu.SetActive(false);
            cheatsMenu.SetActive(true);
            difficultyMenuButtons.SetActive(false);
        }

        // BACK BUTTONS FOR OPTIONS MENU

        public void BackToPauseMenu()
        {
            optionsMenu.SetActive(false);
            controlsMenu.SetActive(false);
            difficultyMenu.SetActive(false);
            cheatsMenu.SetActive(false);
            difficultyMenuButtons.SetActive(false);
        }
    }
}