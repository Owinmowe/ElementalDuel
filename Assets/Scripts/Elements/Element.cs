using System.Collections.Generic;
using UnityEngine;

namespace Owinmowe.ElementalFrenzy
{
    
    [CreateAssetMenu(fileName = "Element", menuName = "ScriptableObjects/Element", order = 1)]
    public class Element : ScriptableObject
    {

        #region Public Fields

        public string ElementName = "Element";

        public Sprite ElementIcon = default;

        public List<Element> weaknesses = default;

        public List<Element> resistances = default;

        #endregion

        #region Serializable Fields

        #endregion

        #region Private Fields

        #endregion

        #region Unity Methods

        #endregion

        #region Public Methods

        public bool HasWeaknessTo(Element element) => weaknesses.Contains(element);

        public bool HasResistanceTo(Element element) => resistances.Contains(element);

        #endregion

        #region Private Methods

        #endregion

    }

}
