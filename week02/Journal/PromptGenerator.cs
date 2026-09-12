using System;
public class PromptGenerator
{
    public List<string> _prompts =
    [
        "What is something that made you smile today?",
        "What made you grateful today?",
        "If you could do one thing over again today, what would it be?",
        "What is a goal you would like to achieve?",
        "What is your favoite childhood memory?",
        "What skills would you like to learn?",
        "What is something you have been procrastinating?",
        "What is your favorite quote or Bible verse?",
        "What is a song that makes you happy?"
        ];


    public string GetRandomPrompt()
    {
        Random randomTopic = new Random();
        int index = randomTopic.Next(_prompts.Count);
        string randomString = _prompts.ElementAt(index);
        return randomString;
    }

}