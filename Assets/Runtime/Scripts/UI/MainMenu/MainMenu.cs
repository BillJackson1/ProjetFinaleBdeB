using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Final_Survivors.UI.MainMenu
{
    public class MainMenu : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private GameObject creditsMenu;
        [SerializeField] private GameObject optionsMenu; // default tab is "Audio" menu
        [SerializeField] private GameObject controlsMenu;
        [SerializeField] private GameObject difficultyMenu;
        [SerializeField] private GameObject difficultyMenuButtons; // special case
        [SerializeField] private GameObject cheatsMenu;

        [Header("Player Input")]
        [SerializeField] private PlayerInput playerInput;
        [SerializeField] private InputAction showHideMenuAction;

        private TextMeshProUGUI mainTitle;
        public bool introIsPlaying = true;

        private void Awake()
        {
            //Cursor.lockState = CursorLockMode.None; // Unlock the cursor
            Cursor.visible = true; // Make the cursor visible

            mainTitle = GameObject.Find("Text/Logo").GetComponent<TextMeshProUGUI>();
            mainTitle.outlineWidth = 0.2f;
            mainTitle.outlineColor = Color.black;

            playerInput = GetComponent<PlayerInput>();
            showHideMenuAction = playerInput.actions["Show or Hide Menu"];
        }

        private void Update()
        {
            if (optionsMenu.activeSelf == true && showHideMenuAction.triggered)
            {
                BackToPauseMenu(); // return to the main menu
            }

            if (creditsMenu.activeSelf== true && showHideMenuAction.triggered)
            {
                BackToPauseMenu(); // return to the main menu
            }
        }

        public void Credits()
        {
            creditsMenu.SetActive(true);
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
            creditsMenu.SetActive(false);
            optionsMenu.SetActive(false);
            controlsMenu.SetActive(false);
            difficultyMenu.SetActive(false);
            cheatsMenu.SetActive(false);
            difficultyMenuButtons.SetActive(false);
        }
    }
}