using System.Collections.Generic;
using UnityEngine;

namespace Owinmowe.ElementalDuel
{

    public class GameManager : MonoBehaviour
    {

        #region Public Fields

        #endregion

        #region Serializable Fields

        [SerializeField] private int elementsAmount = 4;
        [SerializeField] private Duelist player = default;
        [SerializeField] private Duelist enemy = default;

        #endregion

        #region Private Fields

        #endregion

        #region Unity Methods

        private void Awake()
        {

            player.OnElementCast += (element, index) =>
            {

            };
        
        }

        private void Start()
        {

            SetPlayerElements();

        }

        #endregion

        #region Public Methods

        public void SetPlayerElements() 
        {
            List<Element> elements = ElementManager.Instance.GetRandomDifferentElements(elementsAmount);
            player.SetElements(elements);
            player.UnlockCast();
        }

        #endregion

        #region Private Methods

        #endregion

    }

}
