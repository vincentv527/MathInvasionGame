using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class AdditionQuestions : MonoBehaviour
{
    public AudioSource correct;
    public AudioSource wrong;

    public Animator anim;
    public Text scoreText;
    public Text ans1;
    public Text ans2;
    public Text question;

    private float delayTime = 2f;
    private int score = 0;
    public AddQuestions[] questions;
    private static List<AddQuestions> unansweredQuestions;

    private AddQuestions currentQuestion;
    
    void Start()
    {
        scoreText.text = "SCORE: " + score;
        if (unansweredQuestions == null || unansweredQuestions.Count == 0)
        {
            unansweredQuestions = questions.ToList<AddQuestions>();
            foreach (AddQuestions n in unansweredQuestions)
            {
                n.generateQuestion();
            }
        }
        
        SetRandomQuestion();

    }

    private void SetRandomQuestion()
    {
        int rand = UnityEngine.Random.Range(1, unansweredQuestions.Count);
        currentQuestion = unansweredQuestions[rand];

        if (rand % 2 == 0)
        {
            ans1.text = currentQuestion.realAnswer;
            ans2.text = UnityEngine.Random.Range(1, 11).ToString();
        }
        else
        {
            ans1.text = UnityEngine.Random.Range(1, 11).ToString();
            ans2.text = currentQuestion.realAnswer;
        }
            question.text = currentQuestion.question;
        anim.SetBool("MoveAsteroids", true);
    }

   IEnumerator TransitionToNextQuestion()
    {
        unansweredQuestions.Remove(currentQuestion);

        yield return new WaitForSeconds(delayTime);

        Start();
    }

    public void UserSelectsAsteroid1()
    {
        if(ans1.text == currentQuestion.realAnswer)
        {
            correct.Play();
            UpdateScore();
            question.text = "CORRECT!";
            anim.SetBool("MoveAsteroids", false);
            StartCoroutine(TransitionToNextQuestion());
        }
        else
        {
            wrong.Play();
            question.text = "Sorry, Try Again!";
            anim.SetBool("MoveAsteroids", false);
            StartCoroutine(TransitionToNextQuestion());
        }
    }
    public void UserSelectsAsteroid2()
    {
        if(ans2.text == currentQuestion.realAnswer)
        {
            correct.Play();
            UpdateScore();
            question.text = "CORRECT!";
            anim.SetBool("MoveAsteroids", false);
            StartCoroutine(TransitionToNextQuestion());
        }
        else
        {
            wrong.Play();
            question.text = "Sorry, Try Again!";
            anim.SetBool("MoveAsteroids", false);
            StartCoroutine(TransitionToNextQuestion());
        }
    }
    public void UpdateScore()
    {
        score += 1000;
        scoreText.text = "SCORE: " + score;
    }
    public void Mute()
    {
        AudioListener.pause = !AudioListener.pause;
    }
}