using UnityEngine;
using UnityEngine.UI;

namespace KID
{
    /// <summary>
    /// 等級管理
    /// </summary>
    public class LevelManager : MonoBehaviour
    {
        private int lv = 1;
        private int exp;
        private int expMax;

        [SerializeField, Header("經驗值")]
        private Image imgExp;
        [SerializeField, Header("等級")]
        private Text textLv;
        [SerializeField, Header("經驗值需求表")]
        private int[] expsNeed;
        [SerializeField, Header("武器資料")]
        private DataWeapon dataWeapon;

        [ContextMenu("Setting Exps Need")]
        private void SettingExpsNeed()
        {
            expsNeed = new int[99];

            for (int i = 0; i < expsNeed.Length; i++)
            {
                expsNeed[i] = (i + 1) * 100;
            }
        }

        /// <summary>
        /// 獲得經驗值
        /// </summary>
        /// <param name="getExp">獲得的經驗值</param>
        public void GetExp(int getExp)
        {
            exp += getExp;
            expMax = expsNeed[lv - 1];

            while (exp >= expMax)
            {
                lv++;
                exp -= expMax;
                expMax = expsNeed[lv - 1];

                LevelUp();
            }

            imgExp.fillAmount = (float)exp / (float)expMax;
            textLv.text = "Lv " + lv;
        }

        /// <summary>
        /// 升級
        /// </summary>
        private void LevelUp()
        {
            dataWeapon.attack += 10;
            dataWeapon.interval -= 0.02f;
        }
    }
}
