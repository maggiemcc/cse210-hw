using System;
public class PromptGenerator
{
    public List<string> _prompts =
    [
        "What is something that made you smile today?",
        "What made you grateful today?",
        "If you could do one thing over again, what would it be?",
        "What is a goal you would like to achieve?",
        "What is your favoite childhood memory?",
        "What skill would you like to learn?",
        "What is something you have been procrastinating?",
        "What is your favorite quote?",
        "What is your favorite scripture verse?",
        "What is a song that makes you happy?"
        ];


    public string GetRandomPrompt()
    {
        Random getPrompt = new Random();
        int index = getPrompt.Next(_prompts.Count);
        string randomPrompt = _prompts.ElementAt(index);
        return randomPrompt;
    }

}