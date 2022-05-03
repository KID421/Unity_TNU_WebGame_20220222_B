using UnityEngine;

namespace KID
{
    /// <summary>
    /// 武器：附加在武器物件上
    /// </summary>
    public class Weapon : MonoBehaviour
    {
        [HideInInspector]
        public float attack;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "敵人")
            {
                // print("<color=red>打到敵人：" + collision.gameObject + "</color>");
                collision.gameObject.GetComponent<HurtSystem>().GetHurt(attack);
            }
        }
    }
}

