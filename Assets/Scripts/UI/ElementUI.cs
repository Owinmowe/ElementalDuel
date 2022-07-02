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
        [SerializeField] private TextMeshProUGUI elementTextComponent = default;

        #endregion

        #region Private Fields

        private Color primaryColor = default;
        private Color secondaryColor = default;
        private readonly Color notSelectedColor = Color.gray;

        private bool locked = false;

        #endregion

        #region Unity Methods

        private void Update()
        {
            if (locked) return;
            UpdateColors(primaryColor, secondaryColor);
        }

        #endregion

        #region Public Methods

        public void Lock()
        {
            locked = true;

            UpdateColors(notSelectedColor, notSelectedColor);

            elementImage.color = notSelectedColor;
        }

        public void SetElement(Element element) 
        {
            locked = false;

            elementTextComponent.text = element.Name;
            primaryColor = element.PrimaryColor;
            secondaryColor = element.SecondaryColor;

            elementImage.sprite = element.Icon;
            elementImage.color = Color.white;
        }

        #endregion

        #region Private Methods

        private void UpdateColors(Color primary, Color secondary) 
        {
            VertexGradient gradient;
            gradient.topLeft = Color.Lerp(primary, secondary, Mathf.PingPong(Time.time, 1));
            gradient.topRight = Color.Lerp(primary, secondary, Mathf.PingPong(Time.time, 1));
            gradient.bottomLeft = Color.Lerp(secondary, primary, Mathf.PingPong(Time.time, 1));
            gradient.bottomRight = Color.Lerp(secondary, primary, Mathf.PingPong(Time.time, 1));
            elementTextComponent.colorGradient = gradient;
        }

        #endregion

    }

}
