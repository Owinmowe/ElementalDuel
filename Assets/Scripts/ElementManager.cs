using UnityEngine;

namespace Owinmowe.ElementalFrenzy
{

    public class ElementManager : MonoBehaviour
    {

        #region Public Fields

        #endregion

        #region Serializable Fields

        #endregion

        #region Private Fields

        private Element[] elements = default;

        #endregion

        #region Unity Methods

        private void Awake()
        {
            elements = Resources.LoadAll<Element>("Elements");
        }

        #endregion

        #region Public Methods

        #endregion

        #region Private Methods

        #endregion

    }

}
