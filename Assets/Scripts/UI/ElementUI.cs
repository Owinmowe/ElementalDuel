using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Owinmowe.ElementalDuel.UI
{

    public class ElementUI : MonoBehaviour
    {

        #region Public Fields

        #endregion

        #region Serializable Fields

        [SerializeField] private Image elementImage = default;
        [SerializeField] private TextMeshProUGUI elementText = default;

        #endregion

        #region Private Fields

        #endregion

        #region Unity Methods

        #endregion

        #region Public Methods

        public void SetElement(string name, Sprite icon) 
        {
            elementText.text = name;
            elementImage.sprite = icon;
        }

        #endregion

        #region Private Methods

        #endregion

    }

}
