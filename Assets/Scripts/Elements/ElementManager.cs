using System.Collections.Generic;
using UnityEngine;

namespace Owinmowe.ElementalDuel
{

    public class ElementManager : MonoBehaviour
    {

        #region Public Fields

        static public ElementManager Instance => instance;

        #endregion

        #region Serializable Fields

        #endregion

        #region Private Fields

        static private ElementManager instance = default;

        private Element[] elements = default;

        #endregion

        #region Unity Methods

        private void Awake()
        {

            if(instance == null) 
            {
                instance = this;
            }
            else 
            {
                Destroy(gameObject);
            }

            elements = Resources.LoadAll<Element>("Elements");

        }

        #endregion

        #region Public Methods

        public Element GetRandomElement() => elements[Random.Range(0, elements.Length)];

        public List<Element> GetRandomDifferentElements(int amount)
        {

            if (amount > elements.Length)
            {
                Debug.Log("Can't return a list bigger than the max amount of elements.");
            }

            List<Element> newElements = new List<Element>();

            for (int i = 0; i < elements.Length; i++)
            {
                newElements.Add(elements[i]);
            }

            Shuffle(newElements);

            for (int i = newElements.Count - 1; i >= amount; i--)
            {
                newElements.RemoveAt(i);
            }

            return newElements;

        }

        #endregion

        #region Private Methods

        private void Shuffle<T>(List<T> ts)
        {
            var count = ts.Count;
            var last = count - 1;
            for (var i = 0; i < last; ++i)
            {
                var r = Random.Range(i, count);
                var tmp = ts[i];
                ts[i] = ts[r];
                ts[r] = tmp;
            }
        }

        #endregion

    }

}
