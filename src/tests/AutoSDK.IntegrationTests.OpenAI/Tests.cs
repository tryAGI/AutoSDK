using System.Text.Json;

namespace OpenApiGenerator.IntegrationTests;

[TestClass]
public class OpenAiTests
{
    private static OpenAiClient GetAuthorizedApi()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("OPENAI_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("OPENAI_API_KEY environment variable is not found.");

        var client = new OpenAiClient();
        client.AuthorizeUsingBearer(apiKey);

        return client;
    }
    
    [TestMethod]
    public async Task CreateChatCompletion()
    {
        using var api = GetAuthorizedApi();
        var response = await api.Chat.CreateChatCompletionAsync(
            request: new CreateChatCompletionRequest(new CreateChatCompletionRequestVariant2
            {
                Messages = new ChatCompletionRequestMessage[]
                {
                    new ChatCompletionRequestSystemMessage
                    {
                        Content = "You are a helpful weather assistant.",
                        Role = ChatCompletionRequestSystemMessageRole.System,
                    },
                    new ChatCompletionRequestUserMessage
                    {
                        Content = new ChatCompletionRequestUserMessageContentPart[]
                        {
                            new ChatCompletionRequestMessageContentPartText
                            {
                                Type = ChatCompletionRequestMessageContentPartTextType.Text,
                                Text = "What's on this image?",
                            },
                            new ChatCompletionRequestMessageContentPartImage
                            {
                                Type = ChatCompletionRequestMessageContentPartImageType.ImageUrl,
                                ImageUrl = new ChatCompletionRequestMessageContentPartImageImageUrl
                                {
                                    Url = await new Uri("https://raw.githubusercontent.com/srirammanikumar/DogBreedClassifier/master/images/Labrador_retriever_06455.jpg").DownloadAsBase64UrlAsync().ConfigureAwait(false),
                                },
                            },
                        },
                        Role = ChatCompletionRequestUserMessageRole.User,
                    },
                },
                Model = ModelIdsSharedEnum.Gpt4o,
            })).ConfigureAwait(false);
        response.Choices.ElementAt(0).Message.Content.Should().NotBeEmpty();

        Console.WriteLine(response.Choices.ElementAt(0).Message.Content);
    }
    
    [TestMethod]
    public void CreateChatCompletionRequestSerialization()
    {
        var request = new CreateChatCompletionRequestVariant2
        {
            Messages = new ChatCompletionRequestMessage[]
            {
                new ChatCompletionRequestSystemMessage
                {
                    Content = "You are a helpful weather assistant.",
                    Role = ChatCompletionRequestSystemMessageRole.System,
                },
                new ChatCompletionRequestUserMessage
                {
                    Content = new ChatCompletionRequestUserMessageContentPart[]
                    {
                        new ChatCompletionRequestMessageContentPartText
                        {
                            Type = ChatCompletionRequestMessageContentPartTextType.Text,
                            Text = "What's on this image?",
                        },
                        new ChatCompletionRequestMessageContentPartImage
                        {
                            Type = ChatCompletionRequestMessageContentPartImageType.ImageUrl,
                            ImageUrl = new ChatCompletionRequestMessageContentPartImageImageUrl
                            {
                                Url = "https://raw.githubusercontent.com/srirammanikumar/DogBreedClassifier/master/images/Labrador_retriever_06455.jpg",
                            },
                        },
                    },
                    Role = ChatCompletionRequestUserMessageRole.User,
                },
            },
            Model = ModelIdsSharedEnum.Gpt35Turbo,
        };
        var json = JsonSerializer.Serialize(request, SourceGenerationContext.Default.CreateChatCompletionRequestVariant2);

        json.Should().Be(@"{
  ""messages"": [
    {
      ""content"": ""You are a helpful weather assistant."",
      ""role"": ""system""
    },
    {
      ""content"": [
        {
          ""type"": ""text"",
          ""text"": ""What\u0027s on this image?""
        },
        {
          ""type"": ""image_url"",
          ""image_url"": {
            ""url"": ""https://raw.githubusercontent.com/srirammanikumar/DogBreedClassifier/master/images/Labrador_retriever_06455.jpg""
          }
        }
      ],
      ""role"": ""user""
    }
  ],
  ""model"": ""gpt-3.5-turbo""
}");
    }
}
