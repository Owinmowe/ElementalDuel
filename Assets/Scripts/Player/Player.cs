using System.Collections.Generic;
using UnityEngine;

namespace Owinmowe.ElementalDuel
{

    public class Player : MonoBehaviour
    {

        #region Public Fields

        public System.Action OnElementsChanged = default;

        public List<Element> CurrentElements 
        {
            get
            {
                return currentElements;
            }
            private set
            {
                currentElements = value;
            }
        }

        #endregion

        #region Serializable Fields

        [SerializeField] private int elementsAmount = 4;

        #endregion

        #region Private Fields

        [SerializeField] private List<Element> currentElements = default;

        #endregion

        #region Unity Methods

        private void Start()
        {
            ChangeElements();
        }

        #endregion

        #region Public Methods

        public void ChangeElements() 
        {
            currentElements = ElementManager.Instance.GetRandomDifferentElements(elementsAmount);
            OnElementsChanged?.Invoke();
        }

        #endregion

        #region Private Methods

        #endregion

    }

}
