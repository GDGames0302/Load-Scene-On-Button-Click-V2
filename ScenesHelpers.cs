using System.Collections.Generic;
using UnityEngine.SceneManagement;

namespace GDGames.SceneManagement
{
    public static class ScenesHelpers
    {
        public static string[] GetAllScenesInBuildSettings()
        {
            List<string> sceneNames = new List<string>();

            for (int i = 0; i < SceneManager.sceneCountInBuildSettings; i++)
            {
                string scenePath = SceneUtility.GetScenePathByBuildIndex(i);
                string sceneName = System.IO.Path.GetFileNameWithoutExtension(scenePath);

                sceneNames.Add(sceneName);
            }

            return sceneNames.ToArray();
        }
    }
}