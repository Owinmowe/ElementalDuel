using System.Collections.Generic;
using UnityEngine;

namespace Owinmowe.ElementalDuel
{

    public class Duelist : MonoBehaviour
    {

        #region Public Fields

        public bool ElementCasted { get; private set; }

        public System.Action OnElementsChanged = default;
        public System.Action<Element, int> OnElementCast = default;

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

        #endregion

        #region Private Fields

        private List<Element> currentElements = new List<Element>();

        #endregion

        #region Unity Methods

        #endregion

        #region Public Methods

        public void SetElements(List<Element> elements)
        {
            currentElements = elements;
            OnElementsChanged?.Invoke();
        }

        public void UseElement(int elementIndex) 
        {
            if (ElementCasted) return;
            ElementCasted = true;
            OnElementCast?.Invoke(currentElements[elementIndex], elementIndex);
        }

        public void UnlockCast() => ElementCasted = false;

        #endregion

        #region Private Methods

        #endregion

    }

}
