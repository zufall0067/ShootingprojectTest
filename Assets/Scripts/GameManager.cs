using System.Collections;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Vector2 MinPosition { get; private set; }
    public Vector2 MaxPosition { get; private set; }

    [Header("적 프리팹")]
    [SerializeField]
    private GameObject enemyPrefab = null;

    private void Start()
    {
        MinPosition = new Vector2(-3f, -1.5f);
        MaxPosition = new Vector2(3f, 1.5f);
        UpdateUI();
        StartCoroutine(SpawnEnemy());
        // TODO : 적 생성 코루틴을 실행하세요.
    }

    private IEnumerator SpawnEnemy()
    {
        int i = 2;
            while (i > 1)
            {
            float Randomy = Random.Range(-1.5f, 1.5f);
            float delay = Random.Range(0.2f, 0.5f);

            for (int j = 1; j < 6; j++)
            {
                Instantiate(enemyPrefab, new Vector2(5f, Randomy), Quaternion.identity);
                yield return new WaitForSeconds(delay);
            }
            // TODO: 적을 생성하는 스크립트를 완성하세요.
            // 1) enemyPrefab에 들어갈 프리팹을 먼저 만들어야 합니다.
            // 2) enemyPrefab 변수를 Inspector에서 채워줘야 합니다.
            // 3) 적의 위치는 x 위치를 5f로 고정, y 위치는 랜덤으로 생성합니다.
            // 4) 적은 5마리를 같은 위치에 반복하여 생성합니다.
            // 5) 랜덤 위치 및 딜레이는 Random.Range()를 사용합니다.

            yield return new WaitForSeconds(1f);
        }
    }
    
   

    private void UpdateUI()
    {
        //string.Format()
        // TODO: 이 함수에 UI를 새로고침하는 스크립트를 작성하세요.
        // 1) 점수가 올라가거나, 플레이어가 사망하면 이 함수를 실행합니다.
        // 2) UnityEngine.UI를 사용해서 씬의 Text들을 변수로 받아와야 합니다.
        // 3) string.Format()을 사용해서 씬에 있는 UI와 동일한 모양이 되도록 표시합니다.
    }
}
