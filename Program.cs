using System;

Main();

void Main() {

  List<string> responses = new List<string>()
  {
    "As I see it, yes.",
    "Ask again later.",
    "Better not tell you now.",
    "Cannot predict now.",
    "Concentrate and ask again.",
    "Don’t count on it.",
    "It is certain.",
    "It is decidedly so.",
    "Most likely.",
    "My reply is no.",
    "My sources say no.",
    "Outlook not so good.",
    "Outlook good.",
    "Reply hazy, try again.",
    "Signs point to yes.",
    "Very doubtful.",
    "Without a doubt.",
    "Yes.",
    "Yes – definitely.",
    "You may rely on it."
  };


  string GenerateRandoResponse()
  {
    Random r = new Random();
    return responses[r.Next(responses.Count - 1)];
  }

  while(true) 
  {
    Console.WriteLine($"Ask me anything!");

    // ? sets value to nullable to avoid "Dereference of a possibly null reference."
    string q = Console.ReadLine()?.ToLower() ?? "";

    if (q == "no")
    {
      Console.WriteLine($"Fine, be that way. Seeya.");
      break; 
    }
    if (q.Length > 0 )
    {
      Console.WriteLine(GenerateRandoResponse());
    }
    else
    {
      Console.WriteLine($"Can't predict the future if you don't ask a question!");
    }
  }
  
}
