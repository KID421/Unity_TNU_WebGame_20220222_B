using UnityEngine;

namespace KID
{
    /// <summary>
    /// 生成系統
    /// </summary>
    public class SpawnSystem : MonoBehaviour
    {
        [SerializeField, Header("生成敵人物件")]
        private GameObject goEnemy;
        [SerializeField, Header("敵人生成點")]
        private Transform[] traSpawn;
        [SerializeField, Header("生成延遲"), Range(0, 3)]
        private float delay = 1;
        [SerializeField, Header("生成間隔"), Range(0, 3)]
        private float interval = 0.7f;

        private void Awake()
        {
            // 重複呼叫(方法名稱，延遲時間，間隔時間)
            InvokeRepeating("Spawn", delay, interval);
        }

        /// <summary>
        /// 生成
        /// </summary>
        private void Spawn()
        {
            int ran = Random.Range(0, traSpawn.Length);
            Instantiate(goEnemy, traSpawn[ran].position, Quaternion.identity);
        }
    }
}
