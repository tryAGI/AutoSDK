//HintName: G.Commands.ChatCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ChatCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? xClientName,
            global::G.ChatAccepts? accepts,
            global::System.Collections.Generic.IList<global::G.Message>? chatHistory,
            global::G.ChatRequestCitationQuality? citationQuality,
            global::System.Collections.Generic.IList<global::G.ChatConnector>? connectors,
            string? conversationId,
            global::System.Collections.Generic.IList<global::G.ChatDocument>? documents,
            bool? forceSingleStep,
            double frequencyPenalty,
            int k,
            int maxInputTokens,
            int maxTokens,
            string message,
            string? model,
            double p,
            string? preamble,
            double presencePenalty,
            global::G.ChatRequestPromptTruncation? promptTruncation,
            global::G.ResponseFormat? responseFormat,
            global::G.ChatRequestSafetyMode? safetyMode,
            bool? searchQueriesOnly,
            int? seed,
            global::System.Collections.Generic.IList<string> stopSequences,
            bool? stream,
            float? temperature,
            global::System.Collections.Generic.IList<global::G.ToolResult>? toolResults,
            global::System.Collections.Generic.IList<global::G.Tool>? tools,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.OneOf<global::G.NonStreamedChatResponse, global::G.StreamedChatResponse?> response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<double> FrequencyPenalty { get; } = new(
            name: "frequencyPenalty")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<int> K { get; } = new(
            name: "k")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<int> MaxInputTokens { get; } = new(
            name: "maxInputTokens")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<int> MaxTokens { get; } = new(
            name: "maxTokens")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> Message { get; } = new(
            name: "message")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<double> P { get; } = new(
            name: "p")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<double> PresencePenalty { get; } = new(
            name: "presencePenalty")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<string>> StopSequences { get; } = new(
            name: "stopSequences")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> XClientName { get; } = new(
            name: "xClientName")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.ChatAccepts?> Accepts { get; } = new(
            name: "accepts")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.Message>?> ChatHistory { get; } = new(
            name: "chatHistory")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.ChatRequestCitationQuality?> CitationQuality { get; } = new(
            name: "citationQuality")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.ChatConnector>?> Connectors { get; } = new(
            name: "connectors")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> ConversationId { get; } = new(
            name: "conversationId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.ChatDocument>?> Documents { get; } = new(
            name: "documents")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<bool?> ForceSingleStep { get; } = new(
            name: "forceSingleStep")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Model { get; } = new(
            name: "model")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Preamble { get; } = new(
            name: "preamble")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.ChatRequestPromptTruncation?> PromptTruncation { get; } = new(
            name: "promptTruncation")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.ResponseFormat?> ResponseFormat { get; } = new(
            name: "responseFormat")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.ChatRequestSafetyMode?> SafetyMode { get; } = new(
            name: "safetyMode")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<bool?> SearchQueriesOnly { get; } = new(
            name: "searchQueriesOnly")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> Seed { get; } = new(
            name: "seed")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<bool?> Stream { get; } = new(
            name: "stream")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<float?> Temperature { get; } = new(
            name: "temperature")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.ToolResult>?> ToolResults { get; } = new(
            name: "toolResults")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.Tool>?> Tools { get; } = new(
            name: "tools")
        {
            Description = @"",
        };
        public ChatCommand(G.IApi client) : base(
            name: "chat",
            description: @"Generates a text response to a user message.
To learn how to use the Chat API and RAG follow our [Text Generation guides](https://docs.cohere.com/docs/chat-api).")
        {
            _client = client;

            Arguments.Add(FrequencyPenalty);
            Arguments.Add(K);
            Arguments.Add(MaxInputTokens);
            Arguments.Add(MaxTokens);
            Arguments.Add(Message);
            Arguments.Add(P);
            Arguments.Add(PresencePenalty);
            Arguments.Add(StopSequences);
            Options.Add(XClientName);
            Options.Add(Accepts);
            Options.Add(ChatHistory);
            Options.Add(CitationQuality);
            Options.Add(Connectors);
            Options.Add(ConversationId);
            Options.Add(Documents);
            Options.Add(ForceSingleStep);
            Options.Add(Model);
            Options.Add(Preamble);
            Options.Add(PromptTruncation);
            Options.Add(ResponseFormat);
            Options.Add(SafetyMode);
            Options.Add(SearchQueriesOnly);
            Options.Add(Seed);
            Options.Add(Stream);
            Options.Add(Temperature);
            Options.Add(ToolResults);
            Options.Add(Tools);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var xClientName = parseResult.GetRequiredValue(XClientName);
            var accepts = parseResult.GetRequiredValue(Accepts);
            var chatHistory = parseResult.GetRequiredValue(ChatHistory);
            var citationQuality = parseResult.GetRequiredValue(CitationQuality);
            var connectors = parseResult.GetRequiredValue(Connectors);
            var conversationId = parseResult.GetRequiredValue(ConversationId);
            var documents = parseResult.GetRequiredValue(Documents);
            var forceSingleStep = parseResult.GetRequiredValue(ForceSingleStep);
            var frequencyPenalty = parseResult.GetRequiredValue(FrequencyPenalty);
            var k = parseResult.GetRequiredValue(K);
            var maxInputTokens = parseResult.GetRequiredValue(MaxInputTokens);
            var maxTokens = parseResult.GetRequiredValue(MaxTokens);
            var message = parseResult.GetRequiredValue(Message);
            var model = parseResult.GetRequiredValue(Model);
            var p = parseResult.GetRequiredValue(P);
            var preamble = parseResult.GetRequiredValue(Preamble);
            var presencePenalty = parseResult.GetRequiredValue(PresencePenalty);
            var promptTruncation = parseResult.GetRequiredValue(PromptTruncation);
            var responseFormat = parseResult.GetRequiredValue(ResponseFormat);
            var safetyMode = parseResult.GetRequiredValue(SafetyMode);
            var searchQueriesOnly = parseResult.GetRequiredValue(SearchQueriesOnly);
            var seed = parseResult.GetRequiredValue(Seed);
            var stopSequences = parseResult.GetRequiredValue(StopSequences);
            var stream = parseResult.GetRequiredValue(Stream);
            var temperature = parseResult.GetRequiredValue(Temperature);
            var toolResults = parseResult.GetRequiredValue(ToolResults);
            var tools = parseResult.GetRequiredValue(Tools);

            Validate(
                parseResult: parseResult,
                xClientName: xClientName,
                accepts: accepts,
                chatHistory: chatHistory,
                citationQuality: citationQuality,
                connectors: connectors,
                conversationId: conversationId,
                documents: documents,
                forceSingleStep: forceSingleStep,
                frequencyPenalty: frequencyPenalty,
                k: k,
                maxInputTokens: maxInputTokens,
                maxTokens: maxTokens,
                message: message,
                model: model,
                p: p,
                preamble: preamble,
                presencePenalty: presencePenalty,
                promptTruncation: promptTruncation,
                responseFormat: responseFormat,
                safetyMode: safetyMode,
                searchQueriesOnly: searchQueriesOnly,
                seed: seed,
                stopSequences: stopSequences,
                stream: stream,
                temperature: temperature,
                toolResults: toolResults,
                tools: tools,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ChatAsync(
                xClientName: xClientName,
                accepts: accepts,
                chatHistory: chatHistory,
                citationQuality: citationQuality,
                connectors: connectors,
                conversationId: conversationId,
                documents: documents,
                forceSingleStep: forceSingleStep,
                frequencyPenalty: frequencyPenalty,
                k: k,
                maxInputTokens: maxInputTokens,
                maxTokens: maxTokens,
                message: message,
                model: model,
                p: p,
                preamble: preamble,
                presencePenalty: presencePenalty,
                promptTruncation: promptTruncation,
                responseFormat: responseFormat,
                safetyMode: safetyMode,
                searchQueriesOnly: searchQueriesOnly,
                seed: seed,
                stopSequences: stopSequences,
                stream: stream,
                temperature: temperature,
                toolResults: toolResults,
                tools: tools,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}