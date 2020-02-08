
[System.Serializable]
public class AddQuestions
{
    private int ans1;
    private int ans2;
    private int realans;
    public string question;
    public string realAnswer;
    public string answer1;
    public string answer2;

    public void generateQuestion()
    {
        ans1 = UnityEngine.Random.Range(1, 11);
        ans2 = UnityEngine.Random.Range(1, 11);
        realans = ans1 + ans2;
        question = "What is " + ans1.ToString() + "+" + ans2.ToString();
        realAnswer = realans.ToString();
        answer1 = ans1.ToString();
        answer2 = ans2.ToString();
    }
}
