using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

namespace GDGames.SceneManagement
{
    public class LoadSceneButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
    {
        [HideInInspector]
        public int currentScene;

        [HideInInspector]
        public string[] scenesNames;


        public void OnPointerDown(PointerEventData eventData)
        {
            LoadScene();
        }

        public void OnPointerUp(PointerEventData eventData)
        {

        }


        void LoadScene()
        {
            SceneManager.LoadScene(currentScene);
        }

        #region Unity Editor
#if UNITY_EDITOR
        void Reset()
        {
            GetScenesInBuildSettings();
        }

        void OnValidate()
        {
            GetScenesInBuildSettings();
        }

        public void UpdateScenesNames()
        {
            GetScenesInBuildSettings();
        }

        void GetScenesInBuildSettings()
        {
            scenesNames = ScenesHelpers.GetAllScenesInBuildSettings();
        }
#endif
        #endregion
    }
}