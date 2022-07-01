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

        public List<Element> Weaknesses = default;

        public List<Element> Resistances = default;

        #endregion

        #region Serializable Fields

        #endregion

        #region Private Fields

        #endregion

        #region Unity Methods

        #endregion

        #region Public Methods

        public bool HasWeaknessTo(Element element) => Weaknesses.Contains(element);

        public bool HasResistanceTo(Element element) => Resistances.Contains(element);

        #endregion

        #region Private Methods

        #endregion

    }

}
