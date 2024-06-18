namespace OpenApiGenerator.IntegrationTests;

[TestClass]
public class OpenAiTests
{
    private static OpenAiClient GetAuthorizedApi()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("OPENAI_API_KEY") ??
            throw new AssertInconclusiveException("OPENAI_API_KEY environment variable is not found.");

        var client = new OpenAiClient();
        client.AuthorizeUsingBearer(apiKey);

        return client;
    }
    
    [TestMethod]
    public async Task CreateChatCompletion()
    {
        using var api = GetAuthorizedApi();
        var response = await api.Chat.CreateChatCompletionAsync(
            messages: new ChatCompletionRequestMessage[]
            {
                new ChatCompletionRequestSystemMessage
                {
                    Content = "You are a helpful weather assistant.",
                    Role = ChatCompletionRequestSystemMessageRole.System,
                },
                new ChatCompletionRequestUserMessage
                {
                    Content = "What's the weather like today?",
                    Role = ChatCompletionRequestUserMessageRole.User,
                },
            },
            model: CreateChatCompletionRequestModel.Gpt35Turbo,
            user: "OpenApiGenerator.IntegrationTests.Tests.CreateChatCompletion").ConfigureAwait(false);
        response.Choices.ElementAt(0).Message.Content.Should().NotBeEmpty();

        const string json = @"{
  ""messages"": [
    {
      ""System"": {
        ""content"": ""You are a helpful weather assistant."",
        ""role"": ""system""
      },
      ""IsSystem"": true,
      ""IsUser"": false,
      ""IsAssistant"": false,
      ""IsTool"": false,
      ""IsFunction"": false,
      ""Object"": {
        ""content"": ""You are a helpful weather assistant."",
        ""role"": ""system""
      }
    },
    {
      ""IsSystem"": false,
      ""User"": {
        ""content"": ""What\u0027s the weather like today?"",
        ""role"": ""user""
      },
      ""IsUser"": true,
      ""IsAssistant"": false,
      ""IsTool"": false,
      ""IsFunction"": false,
      ""Object"": {
        ""content"": ""What\u0027s the weather like today?"",
        ""role"": ""user""
      }
    }
  ],
  ""model"": 14,
  ""frequency_penalty"": 0,
  ""logprobs"": false,
  ""n"": 1,
  ""presence_penalty"": 0,
  ""stream"": false,
  ""temperature"": 1,
  ""top_p"": 1,
  ""parallel_tool_calls"": true,
  ""user"": ""OpenApiGenerator.IntegrationTests.Tests.CreateChatCompletion""
}";
        Console.WriteLine(response.Choices.ElementAt(0).Message.Content);
    }
}