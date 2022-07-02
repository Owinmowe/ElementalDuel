#if UNITY_EDITOR

using UnityEngine;
using UnityEditor;

namespace Owinmowe.ElementalDuel.EditorScripts
{
    [CustomEditor(typeof(GameManager))]
    public class GameManagerEditor : Editor
    {

        #region Public Fields

        #endregion

        #region Serializable Fields

        #endregion

        #region Private Fields

        #endregion

        #region Unity Methods

        public override void OnInspectorGUI()
        {

            DrawDefaultInspector();

            var script = (GameManager)target;

            if(Application.isPlaying && GUILayout.Button("Change Player Elements")) 
            {
                script.SetElements();
            }

        }

        #endregion

        #region Public Methods

        #endregion

        #region Private Methods

        #endregion

    }

}

#endif