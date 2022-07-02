using UnityEngine;

namespace Owinmowe.ElementalDuel
{

    public class AnimationControl : MonoBehaviour
    {

        #region Public Fields

        #endregion

        #region Serializable Fields

        [SerializeField] private float animationSpeed = .5f;

        #endregion

        #region Private Fields

        private Animator anim = default;

        private const string ANIM_SPEED_FLOAT = "Speed";

        private const string ANIM_CAST_TRIGGER = "Cast";

        private const string ANIM_HURT_TRIGGER = "Hurt";

        private const string ANIM_DIE_TRIGGER = "Die";

        #endregion

        #region Unity Methods

        private void Awake()
        {
            anim = GetComponent<Animator>();
        }

        private void Start()
        {
            anim.SetFloat(ANIM_SPEED_FLOAT, animationSpeed);
        }

        #endregion

        #region Public Methods

        public void SetCastAnimation() => anim.SetTrigger(ANIM_CAST_TRIGGER);

        public void SetHurtAnimation() => anim.SetTrigger(ANIM_HURT_TRIGGER);

        public void SetDieAnimation() => anim.SetTrigger(ANIM_DIE_TRIGGER);

        #endregion

        #region Private Methods

        #endregion

    }

}
