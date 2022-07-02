using System.Collections.Generic;
using UnityEngine;

namespace Owinmowe.ElementalDuel
{
    
    [CreateAssetMenu(fileName = "Element", menuName = "ScriptableObjects/Element", order = 1)]
    public class Element : ScriptableObject
    {

        #region Public Fields

        public string Name = "Element";

        public Sprite Icon = default;

        public Color PrimaryColor = Color.white;

        public Color SecondaryColor = Color.white;

        public Element Weakness = default;

        #endregion

        #region Serializable Fields

        #endregion

        #region Private Fields

        #endregion

        #region Unity Methods

        #endregion

        #region Public Methods

        #endregion

        #region Private Methods

        #endregion

    }

}
