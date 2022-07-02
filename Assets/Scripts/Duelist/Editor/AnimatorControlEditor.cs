#if UNITY_EDITOR

using UnityEngine; 
using UnityEditor;

namespace Owinmowe.ElementalDuel
{

    [CustomEditor(typeof(AnimationControl))]
    public class AnimatorControlEditor : Editor
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

            var script = (AnimationControl)target;

            if (Application.isPlaying) 
            {

                if(GUILayout.Button("Test Cast Animation")) 
                {
                    script.SetCastAnimation();
                }
                else if (GUILayout.Button("Test Hurt Animation"))
                {
                    script.SetHurtAnimation();
                }
                else if (GUILayout.Button("Test Die Animation"))
                {
                    script.SetDieAnimation();
                }

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