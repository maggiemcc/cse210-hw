using System;
public class PromptGenerator
{
    public List<string> _prompts = ["What is something that made you smile?", "What made you grateful today?", "If you could do one thing over again today what would it be?"];

    public string GetRandomPrompt()
    {
        Random randomTopic = new Random();
        int index = randomTopic.Next(0, _prompts.Count);
        string randomString = _prompts.ElementAt(index);
        return randomString;
    }

}