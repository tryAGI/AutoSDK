using System.Text.Json;

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
            model: CreateChatCompletionRequestModel.Gpt4o,
            user: "OpenApiGenerator.IntegrationTests.Tests.CreateChatCompletion").ConfigureAwait(false);
        response.Choices.ElementAt(0).Message.Content.Should().NotBeEmpty();

        Console.WriteLine(response.Choices.ElementAt(0).Message.Content);
    }
    
    [TestMethod]
    public void CreateChatCompletionRequestSerialization()
    {
        var request = new CreateChatCompletionRequest
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
            Model = CreateChatCompletionRequestModel.Gpt35Turbo,
            User = "OpenApiGenerator.IntegrationTests.Tests.CreateChatCompletion",
        };
        var json = JsonSerializer.Serialize(request, SourceGenerationContext.Default.CreateChatCompletionRequest);

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
            ""url"": ""https://raw.githubusercontent.com/srirammanikumar/DogBreedClassifier/master/images/Labrador_retriever_06455.jpg"",
            ""detail"": ""auto""
          }
        }
      ],
      ""role"": ""user""
    }
  ],
  ""model"": ""gpt-3.5-turbo"",
  ""frequency_penalty"": 0,
  ""logprobs"": false,
  ""n"": 1,
  ""presence_penalty"": 0,
  ""stream"": false,
  ""temperature"": 1,
  ""top_p"": 1,
  ""user"": ""OpenApiGenerator.IntegrationTests.Tests.CreateChatCompletion""
}");
    }
}