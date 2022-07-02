using System.Collections.Generic;
using UnityEngine;

namespace Owinmowe.ElementalDuel
{

    public class GameManager : MonoBehaviour
    {

        #region Public Fields

        public System.Action<bool> OnPlayerCast = default;

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
                foreach (var enemyElement in enemy.CurrentElements)
                {

                }
            };
        
        }

        private void Start()
        {

            SetElements();

        }

        #endregion

        #region Public Methods

        public void SetElements() 
        {

            List<Element> playerElements = ElementManager.Instance.GetRandomDifferentElements(elementsAmount);
            player.SetElements(playerElements);
            player.UnlockCast();

            int enemyElementIndex = Random.Range(0, playerElements.Count);
            List<Element> enemyElements = new List<Element>();
            enemyElements.Add(playerElements[enemyElementIndex].Weakness);
            enemy.SetElements(enemyElements);
            enemy.UnlockCast();
            
        }

        #endregion

        #region Private Methods

        #endregion

    }

}
