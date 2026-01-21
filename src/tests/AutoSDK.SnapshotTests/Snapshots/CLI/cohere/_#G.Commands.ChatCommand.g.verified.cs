//HintName: G.Commands.ChatCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ChatCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? xClientName,
            global::G.ChatAccepts? accepts,
            string message,
            string? model,
            bool? stream,
            string? preamble,
            global::System.Collections.Generic.IList<global::G.Message>? chatHistory,
            string? conversationId,
            global::G.ChatRequestPromptTruncation? promptTruncation,
            global::System.Collections.Generic.IList<global::G.ChatConnector>? connectors,
            bool? searchQueriesOnly,
            global::System.Collections.Generic.IList<global::G.ChatDocument>? documents,
            global::G.ChatRequestCitationQuality? citationQuality,
            float? temperature,
            int maxTokens,
            int maxInputTokens,
            int k,
            double p,
            int? seed,
            global::System.Collections.Generic.IList<string> stopSequences,
            double frequencyPenalty,
            double presencePenalty,
            global::System.Collections.Generic.IList<global::G.Tool>? tools,
            global::System.Collections.Generic.IList<global::G.ToolResult>? toolResults,
            bool? forceSingleStep,
            global::G.ResponseFormat? responseFormat,
            global::G.ChatRequestSafetyMode? safetyMode,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.OneOf<global::G.NonStreamedChatResponse, global::G.StreamedChatResponse?> response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Message { get; } = new(
            name: "message")
        {
            Description = @"Text input for the model to respond to.

Compatible Deployments: Cohere Platform, Azure, AWS Sagemaker/Bedrock, Private Deployments",
        };

        private global::System.CommandLine.Argument<int> MaxTokens { get; } = new(
            name: "maxTokens")
        {
            Description = @"The maximum number of tokens the model will generate as part of the response. Note: Setting a low value may result in incomplete generations.

Compatible Deployments: Cohere Platform, Azure, AWS Sagemaker/Bedrock, Private Deployments",
        };

        private global::System.CommandLine.Argument<int> MaxInputTokens { get; } = new(
            name: "maxInputTokens")
        {
            Description = @"The maximum number of input tokens to send to the model. If not specified, `max_input_tokens` is the model's context length limit minus a small buffer.

Input will be truncated according to the `prompt_truncation` parameter.

Compatible Deployments: Cohere Platform",
        };

        private global::System.CommandLine.Argument<int> K { get; } = new(
            name: "k")
        {
            Description = @"Ensures only the top `k` most likely tokens are considered for generation at each step.
Defaults to `0`, min value of `0`, max value of `500`.

Compatible Deployments: Cohere Platform, Azure, AWS Sagemaker/Bedrock, Private Deployments",
        };

        private global::System.CommandLine.Argument<double> P { get; } = new(
            name: "p")
        {
            Description = @"Ensures that only the most likely tokens, with total probability mass of `p`, are considered for generation at each step. If both `k` and `p` are enabled, `p` acts after `k`.
Defaults to `0.75`. min value of `0.01`, max value of `0.99`.

Compatible Deployments: Cohere Platform, Azure, AWS Sagemaker/Bedrock, Private Deployments",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<string>> StopSequences { get; } = new(
            name: "stopSequences")
        {
            Description = @"A list of up to 5 strings that the model will use to stop generation. If the model generates a string that matches any of the strings in the list, it will stop generating tokens and return the generated text up to that point not including the stop sequence.

Compatible Deployments: Cohere Platform, Azure, AWS Sagemaker/Bedrock, Private Deployments",
        };

        private global::System.CommandLine.Argument<double> FrequencyPenalty { get; } = new(
            name: "frequencyPenalty")
        {
            Description = @"Defaults to `0.0`, min value of `0.0`, max value of `1.0`.

Used to reduce repetitiveness of generated tokens. The higher the value, the stronger a penalty is applied to previously present tokens, proportional to how many times they have already appeared in the prompt or prior generation.

Compatible Deployments: Cohere Platform, Azure, AWS Sagemaker/Bedrock, Private Deployments",
        };

        private global::System.CommandLine.Argument<double> PresencePenalty { get; } = new(
            name: "presencePenalty")
        {
            Description = @"Defaults to `0.0`, min value of `0.0`, max value of `1.0`.

Used to reduce repetitiveness of generated tokens. Similar to `frequency_penalty`, except that this penalty is applied equally to all tokens that have already appeared, regardless of their exact frequencies.

Compatible Deployments: Cohere Platform, Azure, AWS Sagemaker/Bedrock, Private Deployments",
        };

        private global::System.CommandLine.Option<string?> XClientName { get; } = new(
            name: "xClientName")
        {
            Description = @"The name of the project that is making the request.",
        };

        private global::System.CommandLine.Option<global::G.ChatAccepts?> Accepts { get; } = new(
            name: "accepts")
        {
            Description = @"Pass text/event-stream to receive the streamed response as server-sent events. The default is `\n` delimited events.",
        };

        private global::System.CommandLine.Option<string?> Model { get; } = new(
            name: "model")
        {
            Description = @"The name of a compatible [Cohere model](https://docs.cohere.com/docs/models) or the ID of a [fine-tuned](https://docs.cohere.com/docs/chat-fine-tuning) model.

Compatible Deployments: Cohere Platform, Private Deployments",
        };

        private global::System.CommandLine.Option<bool?> Stream { get; } = new(
            name: "stream")
        {
            Description = @"Defaults to `false`.

When `true`, the response will be a JSON stream of events. The final event will contain the complete response, and will have an `event_type` of `""stream-end""`.

Streaming is beneficial for user interfaces that render the contents of the response piece by piece, as it gets generated.

Compatible Deployments: Cohere Platform, Azure, AWS Sagemaker/Bedrock, Private Deployments",
        };

        private global::System.CommandLine.Option<string?> Preamble { get; } = new(
            name: "preamble")
        {
            Description = @"When specified, the default Cohere preamble will be replaced with the provided one. Preambles are a part of the prompt used to adjust the model's overall behavior and conversation style, and use the `SYSTEM` role.

The `SYSTEM` role is also used for the contents of the optional `chat_history=` parameter. When used with the `chat_history=` parameter it adds content throughout a conversation. Conversely, when used with the `preamble=` parameter it adds content at the start of the conversation only.

Compatible Deployments: Cohere Platform, Azure, AWS Sagemaker/Bedrock, Private Deployments",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.Message>?> ChatHistory { get; } = new(
            name: "chatHistory")
        {
            Description = @"A list of previous messages between the user and the model, giving the model conversational context for responding to the user's `message`.

Each item represents a single message in the chat history, excluding the current user turn. It has two properties: `role` and `message`. The `role` identifies the sender (`CHATBOT`, `SYSTEM`, or `USER`), while the `message` contains the text content.

The chat_history parameter should not be used for `SYSTEM` messages in most cases. Instead, to add a `SYSTEM` role message at the beginning of a conversation, the `preamble` parameter should be used.

Compatible Deployments: Cohere Platform, Azure, AWS Sagemaker/Bedrock, Private Deployments",
        };

        private global::System.CommandLine.Option<string?> ConversationId { get; } = new(
            name: "conversationId")
        {
            Description = @"An alternative to `chat_history`.

Providing a `conversation_id` creates or resumes a persisted conversation with the specified ID. The ID can be any non empty string.

Compatible Deployments: Cohere Platform",
        };

        private global::System.CommandLine.Option<global::G.ChatRequestPromptTruncation?> PromptTruncation { get; } = new(
            name: "promptTruncation")
        {
            Description = @"Defaults to `AUTO` when `connectors` are specified and `OFF` in all other cases.

Dictates how the prompt will be constructed.

With `prompt_truncation` set to ""AUTO"", some elements from `chat_history` and `documents` will be dropped in an attempt to construct a prompt that fits within the model's context length limit. During this process the order of the documents and chat history will be changed and ranked by relevance.

With `prompt_truncation` set to ""AUTO_PRESERVE_ORDER"", some elements from `chat_history` and `documents` will be dropped in an attempt to construct a prompt that fits within the model's context length limit. During this process the order of the documents and chat history will be preserved as they are inputted into the API.

With `prompt_truncation` set to ""OFF"", no elements will be dropped. If the sum of the inputs exceeds the model's context length limit, a `TooManyTokens` error will be returned.

Compatible Deployments:
 - AUTO: Cohere Platform Only
 - AUTO_PRESERVE_ORDER: Azure, AWS Sagemaker/Bedrock, Private Deployments",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.ChatConnector>?> Connectors { get; } = new(
            name: "connectors")
        {
            Description = @"Accepts `{""id"": ""web-search""}`, and/or the `""id""` for a custom [connector](https://docs.cohere.com/docs/connectors), if you've [created](https://docs.cohere.com/v1/docs/creating-and-deploying-a-connector) one.

When specified, the model's reply will be enriched with information found by querying each of the connectors (RAG).

Compatible Deployments: Cohere Platform",
        };

        private global::System.CommandLine.Option<bool?> SearchQueriesOnly { get; } = new(
            name: "searchQueriesOnly")
        {
            Description = @"Defaults to `false`.

When `true`, the response will only contain a list of generated search queries, but no search will take place, and no reply from the model to the user's `message` will be generated.

Compatible Deployments: Cohere Platform, Azure, AWS Sagemaker/Bedrock, Private Deployments",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.ChatDocument>?> Documents { get; } = new(
            name: "documents")
        {
            Description = @"A list of relevant documents that the model can cite to generate a more accurate reply. Each document is a string-string dictionary.

Example:
```
[
  { ""title"": ""Tall penguins"", ""text"": ""Emperor penguins are the tallest."" },
  { ""title"": ""Penguin habitats"", ""text"": ""Emperor penguins only live in Antarctica."" },
]
```

Keys and values from each document will be serialized to a string and passed to the model. The resulting generation will include citations that reference some of these documents.

Some suggested keys are ""text"", ""author"", and ""date"". For better generation quality, it is recommended to keep the total word count of the strings in the dictionary to under 300 words.

An `id` field (string) can be optionally supplied to identify the document in the citations. This field will not be passed to the model.

An `_excludes` field (array of strings) can be optionally supplied to omit some key-value pairs from being shown to the model. The omitted fields will still show up in the citation object. The ""_excludes"" field will not be passed to the model.

See ['Document Mode'](https://docs.cohere.com/docs/retrieval-augmented-generation-rag#document-mode) in the guide for more information.

Compatible Deployments: Cohere Platform, Azure, AWS Sagemaker/Bedrock, Private Deployments",
        };

        private global::System.CommandLine.Option<global::G.ChatRequestCitationQuality?> CitationQuality { get; } = new(
            name: "citationQuality")
        {
            Description = @"Defaults to `""accurate""`.

Dictates the approach taken to generating citations as part of the RAG flow by allowing the user to specify whether they want `""accurate""` results, `""fast""` results or no results.

Compatible Deployments: Cohere Platform, Azure, AWS Sagemaker/Bedrock, Private Deployments",
        };

        private global::System.CommandLine.Option<float?> Temperature { get; } = new(
            name: "temperature")
        {
            Description = @"Defaults to `0.3`.

A non-negative float that tunes the degree of randomness in generation. Lower temperatures mean less random generations, and higher temperatures mean more random generations.

Randomness can be further maximized by increasing the  value of the `p` parameter.

Compatible Deployments: Cohere Platform, Azure, AWS Sagemaker/Bedrock, Private Deployments",
        };

        private global::System.CommandLine.Option<int?> Seed { get; } = new(
            name: "seed")
        {
            Description = @"If specified, the backend will make a best effort to sample tokens
deterministically, such that repeated requests with the same
seed and parameters should return the same result. However,
determinism cannot be totally guaranteed.

Compatible Deployments: Cohere Platform, Azure, AWS Sagemaker/Bedrock, Private Deployments",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.Tool>?> Tools { get; } = new(
            name: "tools")
        {
            Description = @"A list of available tools (functions) that the model may suggest invoking before producing a text response.

When `tools` is passed (without `tool_results`), the `text` field in the response will be `""""` and the `tool_calls` field in the response will be populated with a list of tool calls that need to be made. If no calls need to be made, the `tool_calls` array will be empty.

Compatible Deployments: Cohere Platform, Azure, AWS Sagemaker/Bedrock, Private Deployments",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.ToolResult>?> ToolResults { get; } = new(
            name: "toolResults")
        {
            Description = @"A list of results from invoking tools recommended by the model in the previous chat turn. Results are used to produce a text response and will be referenced in citations. When using `tool_results`, `tools` must be passed as well.
Each tool_result contains information about how it was invoked, as well as a list of outputs in the form of dictionaries.

**Note**: `outputs` must be a list of objects. If your tool returns a single object (eg `{""status"": 200}`), make sure to wrap it in a list.
```
tool_results = [
  {
    ""call"": {
      ""name"": <tool name>,
      ""parameters"": {
        <param name>: <param value>
      }
    },
    ""outputs"": [{
      <key>: <value>
    }]
  },
  ...
]
```
**Note**: Chat calls with `tool_results` should not be included in the Chat history to avoid duplication of the message text.

Compatible Deployments: Cohere Platform, Azure, AWS Sagemaker/Bedrock, Private Deployments",
        };

        private global::System.CommandLine.Option<bool?> ForceSingleStep { get; } = new(
            name: "forceSingleStep")
        {
            Description = @"Forces the chat to be single step. Defaults to `false`.",
        };

        private global::System.CommandLine.Option<global::G.ResponseFormat?> ResponseFormat { get; } = new(
            name: "responseFormat")
        {
            Description = @"Configuration for forcing the model output to adhere to the specified format. Supported on [Command R 03-2024](https://docs.cohere.com/docs/command-r), [Command R+ 04-2024](https://docs.cohere.com/docs/command-r-plus) and newer models.

The model can be forced into outputting JSON objects (with up to 5 levels of nesting) by setting `{ ""type"": ""json_object"" }`.

A [JSON Schema](https://json-schema.org/) can optionally be provided, to ensure a specific structure.

**Note**: When using  `{ ""type"": ""json_object"" }` your `message` should always explicitly instruct the model to generate a JSON (eg: _""Generate a JSON ...""_) . Otherwise the model may end up getting stuck generating an infinite stream of characters and eventually run out of context length.
**Limitation**: The parameter is not supported in RAG mode (when any of `connectors`, `documents`, `tools`, `tool_results` are provided).",
        };

        private global::System.CommandLine.Option<global::G.ChatRequestSafetyMode?> SafetyMode { get; } = new(
            name: "safetyMode")
        {
            Description = @"Used to select the [safety instruction](https://docs.cohere.com/docs/safety-modes) inserted into the prompt. Defaults to `CONTEXTUAL`.
When `NONE` is specified, the safety instruction will be omitted.

Safety modes are not yet configurable in combination with `tools`, `tool_results` and `documents` parameters.

**Note**: This parameter is only compatible newer Cohere models, starting with [Command R 08-2024](https://docs.cohere.com/docs/command-r#august-2024-release) and [Command R+ 08-2024](https://docs.cohere.com/docs/command-r-plus#august-2024-release).

**Note**: `command-r7b-12-2024` and newer models only support `""CONTEXTUAL""` and `""STRICT""` modes.

Compatible Deployments: Cohere Platform, Azure, AWS Sagemaker/Bedrock, Private Deployments",
        };
        public ChatCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "chat",
            description: @"Generates a text response to a user message.
To learn how to use the Chat API and RAG follow our [Text Generation guides](https://docs.cohere.com/docs/chat-api).")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Message);
            Arguments.Add(MaxTokens);
            Arguments.Add(MaxInputTokens);
            Arguments.Add(K);
            Arguments.Add(P);
            Arguments.Add(StopSequences);
            Arguments.Add(FrequencyPenalty);
            Arguments.Add(PresencePenalty);
            Options.Add(XClientName);
            Options.Add(Accepts);
            Options.Add(Model);
            Options.Add(Stream);
            Options.Add(Preamble);
            Options.Add(ChatHistory);
            Options.Add(ConversationId);
            Options.Add(PromptTruncation);
            Options.Add(Connectors);
            Options.Add(SearchQueriesOnly);
            Options.Add(Documents);
            Options.Add(CitationQuality);
            Options.Add(Temperature);
            Options.Add(Seed);
            Options.Add(Tools);
            Options.Add(ToolResults);
            Options.Add(ForceSingleStep);
            Options.Add(ResponseFormat);
            Options.Add(SafetyMode);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var xClientName = parseResult.GetRequiredValue(XClientName);
            var accepts = parseResult.GetRequiredValue(Accepts);
            var message = parseResult.GetRequiredValue(Message);
            var model = parseResult.GetRequiredValue(Model);
            var stream = parseResult.GetRequiredValue(Stream);
            var preamble = parseResult.GetRequiredValue(Preamble);
            var chatHistory = parseResult.GetRequiredValue(ChatHistory);
            var conversationId = parseResult.GetRequiredValue(ConversationId);
            var promptTruncation = parseResult.GetRequiredValue(PromptTruncation);
            var connectors = parseResult.GetRequiredValue(Connectors);
            var searchQueriesOnly = parseResult.GetRequiredValue(SearchQueriesOnly);
            var documents = parseResult.GetRequiredValue(Documents);
            var citationQuality = parseResult.GetRequiredValue(CitationQuality);
            var temperature = parseResult.GetRequiredValue(Temperature);
            var maxTokens = parseResult.GetRequiredValue(MaxTokens);
            var maxInputTokens = parseResult.GetRequiredValue(MaxInputTokens);
            var k = parseResult.GetRequiredValue(K);
            var p = parseResult.GetRequiredValue(P);
            var seed = parseResult.GetRequiredValue(Seed);
            var stopSequences = parseResult.GetRequiredValue(StopSequences);
            var frequencyPenalty = parseResult.GetRequiredValue(FrequencyPenalty);
            var presencePenalty = parseResult.GetRequiredValue(PresencePenalty);
            var tools = parseResult.GetRequiredValue(Tools);
            var toolResults = parseResult.GetRequiredValue(ToolResults);
            var forceSingleStep = parseResult.GetRequiredValue(ForceSingleStep);
            var responseFormat = parseResult.GetRequiredValue(ResponseFormat);
            var safetyMode = parseResult.GetRequiredValue(SafetyMode);

            Validate(
                parseResult: parseResult,
                xClientName: xClientName,
                accepts: accepts,
                message: message,
                model: model,
                stream: stream,
                preamble: preamble,
                chatHistory: chatHistory,
                conversationId: conversationId,
                promptTruncation: promptTruncation,
                connectors: connectors,
                searchQueriesOnly: searchQueriesOnly,
                documents: documents,
                citationQuality: citationQuality,
                temperature: temperature,
                maxTokens: maxTokens,
                maxInputTokens: maxInputTokens,
                k: k,
                p: p,
                seed: seed,
                stopSequences: stopSequences,
                frequencyPenalty: frequencyPenalty,
                presencePenalty: presencePenalty,
                tools: tools,
                toolResults: toolResults,
                forceSingleStep: forceSingleStep,
                responseFormat: responseFormat,
                safetyMode: safetyMode,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ChatAsync(
                xClientName: xClientName,
                accepts: accepts,
                message: message,
                model: model,
                stream: stream,
                preamble: preamble,
                chatHistory: chatHistory,
                conversationId: conversationId,
                promptTruncation: promptTruncation,
                connectors: connectors,
                searchQueriesOnly: searchQueriesOnly,
                documents: documents,
                citationQuality: citationQuality,
                temperature: temperature,
                maxTokens: maxTokens,
                maxInputTokens: maxInputTokens,
                k: k,
                p: p,
                seed: seed,
                stopSequences: stopSequences,
                frequencyPenalty: frequencyPenalty,
                presencePenalty: presencePenalty,
                tools: tools,
                toolResults: toolResults,
                forceSingleStep: forceSingleStep,
                responseFormat: responseFormat,
                safetyMode: safetyMode,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}