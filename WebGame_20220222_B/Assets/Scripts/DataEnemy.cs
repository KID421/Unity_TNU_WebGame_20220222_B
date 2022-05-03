using UnityEngine;

namespace KID
{
    /// <summary>
    /// 敵人資料
    /// </summary>
    [CreateAssetMenu(menuName = "KID/Data Enemy", fileName = "Data Enemy", order = 2)]
    public class DataEnemy : ScriptableObject
    {
        [Header("移動速度"), Range(0, 50)]
        public float speed = 30;
        [Header("攻擊力"), Range(0, 500)]
        public float attack = 10;
        [Header("攻擊冷卻"), Range(0, 7)]
        public float cd = 3.5f;
        [Header("血量"), Range(0, 5000)]
        public float hp = 100;
        [Header("掉落經驗值機率"), Range(0, 1)]
        public float expDropProbability = 0.8f;
        [Header("掉落經驗值類型")]
        public TypeExp typeExp;
        [Header("停止距離"), Range(0, 10)]
        public float stopDistance = 1.5f;
    }

    // enum 列舉：下拉式選單
    /// <summary>
    /// 經驗值類型：小、中、大
    /// </summary>
    public enum TypeExp
    {
        small, middle, big
    }
}

