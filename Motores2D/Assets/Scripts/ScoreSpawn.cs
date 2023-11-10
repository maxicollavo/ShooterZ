using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSpawn : MonoBehaviour
{
    public GameObject cajaPrefab;
    public GameObject score;

    public Transform minPoint;
    public Transform maxPoint;

    private void Start()
    {
        Instantiate();
        EventManager.Instance.Register(GameEventTypes.BallScore, OnBallScore);
    }

    private void OnBallScore(object sender, System.EventArgs e)
    {
        Reset();
    }

    private void Instantiate()
    {
        float randomX = Random.Range(minPoint.position.x, maxPoint.position.x);

        Vector2 randomPosition = new Vector2(randomX, -4);

        score = Instantiate(cajaPrefab, randomPosition, Quaternion.identity);
    }

    private void Reset()
    {
        if(score != null) Destroy(score);
        Instantiate();
    }
}
