using System;
using UnityEngine;

public class BallScore : MonoBehaviour
{
    public Score score;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Score scoreObj = collision.GetComponent<Score>();

        if (scoreObj != null)
        {
            score.ScoreGoal();
            EventManager.Instance.Dispatch(GameEventTypes.BallScore, this, EventArgs.Empty);
        }
    }
}
