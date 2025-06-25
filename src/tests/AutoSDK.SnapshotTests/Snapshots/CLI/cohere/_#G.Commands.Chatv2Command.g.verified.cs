//HintName: G.Commands.Chatv2Command.g.cs

#nullable enable

namespace G
{
    internal sealed partial class Chatv2Command : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? xClientName,
            global::G.CitationOptions? citationOptions,
            global::System.Collections.Generic.IList<global::G.OneOf<string, global::G.Document>>? documents,
            float? frequencyPenalty,
            int? k,
            bool? logprobs,
            int? maxTokens,
            global::System.Collections.Generic.IList<global::G.ChatMessageV2> messages,
            string model,
            float? p,
            float? presencePenalty,
            global::G.ReasoningEffort? reasoningEffort,
            global::G.ResponseFormatV2? responseFormat,
            global::G.Chatv2RequestSafetyMode? safetyMode,
            int? seed,
            global::System.Collections.Generic.IList<string>? stopSequences,
            bool? stream,
            bool? strictTools,
            float? temperature,
            global::G.Chatv2RequestToolChoice? toolChoice,
            global::System.Collections.Generic.IList<global::G.ToolV2>? tools,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.OneOf<global::G.ChatResponse, global::G.StreamedChatResponseV2?> response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.ChatMessageV2>> Messages { get; } = new(
            name: "messages")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> Model { get; } = new(
            name: "model")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> XClientName { get; } = new(
            name: "xClientName")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.CitationOptions?> CitationOptions { get; } = new(
            name: "citationOptions")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.OneOf<string, global::G.Document>>?> Documents { get; } = new(
            name: "documents")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<float?> FrequencyPenalty { get; } = new(
            name: "frequencyPenalty")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> K { get; } = new(
            name: "k")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<bool?> Logprobs { get; } = new(
            name: "logprobs")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> MaxTokens { get; } = new(
            name: "maxTokens")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<float?> P { get; } = new(
            name: "p")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<float?> PresencePenalty { get; } = new(
            name: "presencePenalty")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.ReasoningEffort?> ReasoningEffort { get; } = new(
            name: "reasoningEffort")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.ResponseFormatV2?> ResponseFormat { get; } = new(
            name: "responseFormat")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.Chatv2RequestSafetyMode?> SafetyMode { get; } = new(
            name: "safetyMode")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> Seed { get; } = new(
            name: "seed")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> StopSequences { get; } = new(
            name: "stopSequences")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<bool?> Stream { get; } = new(
            name: "stream")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<bool?> StrictTools { get; } = new(
            name: "strictTools")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<float?> Temperature { get; } = new(
            name: "temperature")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.Chatv2RequestToolChoice?> ToolChoice { get; } = new(
            name: "toolChoice")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.ToolV2>?> Tools { get; } = new(
            name: "tools")
        {
            Description = @"",
        };
        public Chatv2Command(G.IApi client) : base(
            name: "chatv2",
            description: @"Generates a text response to a user message and streams it down, token by token. To learn how to use the Chat API with streaming follow our [Text Generation guides](https://docs.cohere.com/v2/docs/chat-api).

Follow the [Migration Guide](https://docs.cohere.com/v2/docs/migrating-v1-to-v2) for instructions on moving from API v1 to API v2.")
        {
            _client = client;

            Arguments.Add(Messages);
            Arguments.Add(Model);
            Options.Add(XClientName);
            Options.Add(CitationOptions);
            Options.Add(Documents);
            Options.Add(FrequencyPenalty);
            Options.Add(K);
            Options.Add(Logprobs);
            Options.Add(MaxTokens);
            Options.Add(P);
            Options.Add(PresencePenalty);
            Options.Add(ReasoningEffort);
            Options.Add(ResponseFormat);
            Options.Add(SafetyMode);
            Options.Add(Seed);
            Options.Add(StopSequences);
            Options.Add(Stream);
            Options.Add(StrictTools);
            Options.Add(Temperature);
            Options.Add(ToolChoice);
            Options.Add(Tools);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var xClientName = parseResult.GetRequiredValue(XClientName);
            var citationOptions = parseResult.GetRequiredValue(CitationOptions);
            var documents = parseResult.GetRequiredValue(Documents);
            var frequencyPenalty = parseResult.GetRequiredValue(FrequencyPenalty);
            var k = parseResult.GetRequiredValue(K);
            var logprobs = parseResult.GetRequiredValue(Logprobs);
            var maxTokens = parseResult.GetRequiredValue(MaxTokens);
            var messages = parseResult.GetRequiredValue(Messages);
            var model = parseResult.GetRequiredValue(Model);
            var p = parseResult.GetRequiredValue(P);
            var presencePenalty = parseResult.GetRequiredValue(PresencePenalty);
            var reasoningEffort = parseResult.GetRequiredValue(ReasoningEffort);
            var responseFormat = parseResult.GetRequiredValue(ResponseFormat);
            var safetyMode = parseResult.GetRequiredValue(SafetyMode);
            var seed = parseResult.GetRequiredValue(Seed);
            var stopSequences = parseResult.GetRequiredValue(StopSequences);
            var stream = parseResult.GetRequiredValue(Stream);
            var strictTools = parseResult.GetRequiredValue(StrictTools);
            var temperature = parseResult.GetRequiredValue(Temperature);
            var toolChoice = parseResult.GetRequiredValue(ToolChoice);
            var tools = parseResult.GetRequiredValue(Tools);

            Validate(
                parseResult: parseResult,
                xClientName: xClientName,
                citationOptions: citationOptions,
                documents: documents,
                frequencyPenalty: frequencyPenalty,
                k: k,
                logprobs: logprobs,
                maxTokens: maxTokens,
                messages: messages,
                model: model,
                p: p,
                presencePenalty: presencePenalty,
                reasoningEffort: reasoningEffort,
                responseFormat: responseFormat,
                safetyMode: safetyMode,
                seed: seed,
                stopSequences: stopSequences,
                stream: stream,
                strictTools: strictTools,
                temperature: temperature,
                toolChoice: toolChoice,
                tools: tools,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Chatv2Async(
                xClientName: xClientName,
                citationOptions: citationOptions,
                documents: documents,
                frequencyPenalty: frequencyPenalty,
                k: k,
                logprobs: logprobs,
                maxTokens: maxTokens,
                messages: messages,
                model: model,
                p: p,
                presencePenalty: presencePenalty,
                reasoningEffort: reasoningEffort,
                responseFormat: responseFormat,
                safetyMode: safetyMode,
                seed: seed,
                stopSequences: stopSequences,
                stream: stream,
                strictTools: strictTools,
                temperature: temperature,
                toolChoice: toolChoice,
                tools: tools,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}