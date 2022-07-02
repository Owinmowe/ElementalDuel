using UnityEngine;

namespace Owinmowe.ElementalDuel
{

    public class PlayerInput : MonoBehaviour
    {

        #region Public Fields

        #endregion

        #region Serializable Fields

        #endregion

        #region Private Fields

        private Duelist player = default;

        #endregion

        #region Unity Methods

        private void Awake()
        {
            player = GetComponent<Duelist>();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Q)) 
            {
                player.UseElement(0);
            }
            else if (Input.GetKeyDown(KeyCode.W))
            {
                player.UseElement(1);
            }
            else if (Input.GetKeyDown(KeyCode.E))
            {
                player.UseElement(2);
            }
            else if (Input.GetKeyDown(KeyCode.R))
            {
                player.UseElement(3);
            }
        }

        #endregion

        #region Public Methods

        #endregion

        #region Private Methods

        #endregion

    }

}
