using UnityEngine;

[CreateAssetMenu(fileName = "Quests", menuName = "Quests/KillQuest", order = 1)]
public class KillQuest : ScriptableObject
{
    // Set up ScriptableObject Variables
    [SerializeField] public string questName;
    [SerializeField] public string description;
    [SerializeField] private QuestDifficulty _difficulty;
    [SerializeField] private GameObject[] _prefabs;
    private int _progress;
    [SerializeField] private int _requirement;
    [SerializeField] public ArmorBase reward;

    // Class Variables
    private RewardHandler _rewardHandler;
    private EnemySpawner _enemySpawner;
    private GameObject _enemyPrefab;
    private LevelManager _levelManager;

    public void StartQuest()
    {
        _progress = 0;
        _rewardHandler = RewardHandler.instance;
        _enemySpawner = FindObjectOfType<EnemySpawner>();
        _enemyPrefab = ChooseRandomEnemy(_prefabs);
        SpawnQuestEntities(_enemyPrefab);
        _levelManager = LevelManager.instance;
    }

    public void UpdateQuestProgress(int updatedProgress)
    {
        _progress += updatedProgress;

        if (_progress >= _requirement)
            CompleteQuest();
    }

    private void CompleteQuest()    
    {
        _rewardHandler.HandleRewards(reward);
        Debug.Log("Quest Completed");
        _levelManager.NextLevel();
        Debug.Log(_levelManager.GetLevel());
    }

    private void SpawnQuestEntities(GameObject entity)
    {
        _enemySpawner.SpawnEnemies(_requirement, entity);
    }

    private GameObject ChooseRandomEnemy(GameObject[] gameObjects)
    {
        // Get the length of the array
        int length = gameObjects.Length;

        // Choose a random index between 0 and length - 1
        int index = Random.Range(0, length);

        // Return the random indexed enemy choice
        return gameObjects[index];
    }
}
