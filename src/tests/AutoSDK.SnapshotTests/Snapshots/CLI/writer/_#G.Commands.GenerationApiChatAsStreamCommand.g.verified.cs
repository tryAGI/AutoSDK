//HintName: G.Commands.GenerationApiChatAsStreamCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GenerationApiChatAsStreamCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string model,
            global::System.Collections.Generic.IList<global::G.ChatMessage> messages,
            int? maxTokens,
            double? temperature,
            double? topP,
            int? n,
            global::G.OneOf<global::System.Collections.Generic.IList<string>, string>? stop,
            bool? logprobs,
            global::System.Collections.Generic.IList<global::G.Tool>? tools,
            global::G.ToolChoice? toolChoice,
            global::G.StreamOptions? streamOptions,
            global::G.ResponseFormat? responseFormat,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::System.Collections.Generic.IAsyncEnumerable<global::G.ChatCompletionChunk> response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Model { get; } = new(
            name: "model")
        {
            Description = @"The [ID of the model](https://dev.writer.com/home/models) to use for creating the chat completion. Supports `palmyra-x5`, `palmyra-x4`, `palmyra-fin`, `palmyra-med`, `palmyra-creative`, and `palmyra-x-003-instruct`.",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.ChatMessage>> Messages { get; } = new(
            name: "messages")
        {
            Description = @"An array of message objects that form the conversation history or context for the model to respond to. The array must contain at least one message.",
        };

        private global::System.CommandLine.Option<int?> MaxTokens { get; } = new(
            name: "maxTokens")
        {
            Description = @"Defines the maximum number of tokens (words and characters) that the model can generate in the response. This can be adjusted to allow for longer or shorter responses as needed. The maximum value varies by model. See the [models overview](/home/models) for more information about the maximum number of tokens for each model.",
        };

        private global::System.CommandLine.Option<double?> Temperature { get; } = new(
            name: "temperature")
        {
            Description = @"Controls the randomness or creativity of the model's responses. A higher temperature results in more varied and less predictable text, while a lower temperature produces more deterministic and conservative outputs.",
        };

        private global::System.CommandLine.Option<double?> TopP { get; } = new(
            name: "topP")
        {
            Description = @"Sets the threshold for ""nucleus sampling,"" a technique to focus the model's token generation on the most likely subset of tokens. Only tokens with cumulative probability above this threshold are considered, controlling the trade-off between creativity and coherence.",
        };

        private global::System.CommandLine.Option<int?> N { get; } = new(
            name: "n")
        {
            Description = @"Specifies the number of completions (responses) to generate from the model in a single request. This parameter allows for generating multiple responses, offering a variety of potential replies from which to choose.",
        };

        private global::System.CommandLine.Option<global::G.OneOf<global::System.Collections.Generic.IList<string>, string>?> Stop { get; } = new(
            name: "stop")
        {
            Description = @"A token or sequence of tokens that, when generated, will cause the model to stop producing further content. This can be a single token or an array of tokens, acting as a signal to end the output.",
        };

        private global::System.CommandLine.Option<bool?> Logprobs { get; } = new(
            name: "logprobs")
        {
            Description = @"Specifies whether to return log probabilities of the output tokens.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.Tool>?> Tools { get; } = new(
            name: "tools")
        {
            Description = @"An array containing tool definitions for tools that the model can use to generate responses. The tool definitions use JSON schema. You can define your own functions or use one of the built-in `graph`, `llm`, `translation`, or `vision` tools. Note that you can only use one built-in tool type in the array (only one of `graph`, `llm`, `translation`, or `vision`). You can pass multiple [custom tools](https://dev.writer.com/home/tool-calling) of type `function` in the same request.",
        };

        private global::System.CommandLine.Option<global::G.ToolChoice?> ToolChoice { get; } = new(
            name: "toolChoice")
        {
            Description = @"Configure how the model will call functions:
- `auto`: allows the model to automatically choose the tool to use, or not call a tool
- `none`: disables tool calling; the model will instead generate a message
- `required`: requires the model to call one or more tools

You can also use a JSON object to force the model to call a specific tool. For example, `{""type"": ""function"", ""function"": {""name"": ""get_current_weather""}}` requires the model to call the `get_current_weather` function, regardless of the prompt.",
        };

        private global::System.CommandLine.Option<global::G.StreamOptions?> StreamOptions { get; } = new(
            name: "streamOptions")
        {
            Description = @"Additional options for streaming.",
        };

        private global::System.CommandLine.Option<global::G.ResponseFormat?> ResponseFormat { get; } = new(
            name: "responseFormat")
        {
            Description = @"The response format to use for the chat completion, available with `palmyra-x4` and `palmyra-x5`.

`text` is the default response format. [JSON Schema](https://json-schema.org/) is supported for structured responses. If you specify `json_schema`, you must also provide a `json_schema` object.",
        };


        public GenerationApiChatAsStreamCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "chat",
            description: @"Generate a chat completion based on the provided messages. The response shown below is for non-streaming. To learn about streaming responses, see the [chat completion guide](https://dev.writer.com/home/chat-completion).")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Model);
            Arguments.Add(Messages);
            Options.Add(MaxTokens);
            Options.Add(Temperature);
            Options.Add(TopP);
            Options.Add(N);
            Options.Add(Stop);
            Options.Add(Logprobs);
            Options.Add(Tools);
            Options.Add(ToolChoice);
            Options.Add(StreamOptions);
            Options.Add(ResponseFormat);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var model = parseResult.GetRequiredValue(Model);
            var messages = parseResult.GetRequiredValue(Messages);
            var maxTokens = parseResult.GetRequiredValue(MaxTokens);
            var temperature = parseResult.GetRequiredValue(Temperature);
            var topP = parseResult.GetRequiredValue(TopP);
            var n = parseResult.GetRequiredValue(N);
            var stop = parseResult.GetRequiredValue(Stop);
            var logprobs = parseResult.GetRequiredValue(Logprobs);
            var tools = parseResult.GetRequiredValue(Tools);
            var toolChoice = parseResult.GetRequiredValue(ToolChoice);
            var streamOptions = parseResult.GetRequiredValue(StreamOptions);
            var responseFormat = parseResult.GetRequiredValue(ResponseFormat);

            Validate(
                parseResult: parseResult,
                model: model,
                messages: messages,
                maxTokens: maxTokens,
                temperature: temperature,
                topP: topP,
                n: n,
                stop: stop,
                logprobs: logprobs,
                tools: tools,
                toolChoice: toolChoice,
                streamOptions: streamOptions,
                responseFormat: responseFormat,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = _client.GenerationApi.ChatAsStreamAsync(
                model: model,
                messages: messages,
                maxTokens: maxTokens,
                temperature: temperature,
                topP: topP,
                n: n,
                stop: stop,
                logprobs: logprobs,
                tools: tools,
                toolChoice: toolChoice,
                streamOptions: streamOptions,
                responseFormat: responseFormat,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}