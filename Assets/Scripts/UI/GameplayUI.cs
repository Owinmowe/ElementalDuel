using UnityEngine;

namespace Owinmowe.ElementalDuel.UI
{

    public class GameplayUI : MonoBehaviour
    {

        #region Public Fields

        #endregion

        #region Serializable Fields

        [SerializeField] private Duelist player = default;
        [SerializeField] private ElementUI[] elementsUI = default;

        #endregion

        #region Private Fields

        #endregion

        #region Unity Methods

        private void Awake()
        {

            player.OnElementsChanged += () =>
            {
                for (int i = 0; i < elementsUI.Length; i++)
                {
                    var element = player.CurrentElements[i];
                    elementsUI[i].SetElement(element);
                }
            };

            player.OnElementCast += (element, index) =>
            {
                for (int i = 0; i < elementsUI.Length; i++)
                {
                    if (i == index) continue;
                    elementsUI[i].Lock();
                }
            };
        }

        #endregion

        #region Public Methods

        #endregion

        #region Private Methods

        #endregion

    }

}
