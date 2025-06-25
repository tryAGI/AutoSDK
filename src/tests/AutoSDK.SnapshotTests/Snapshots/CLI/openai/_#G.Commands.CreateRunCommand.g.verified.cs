//HintName: G.Commands.CreateRunCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateRunCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string threadId,
            global::System.Collections.Generic.IList<global::G.CreateRunIncludeItem>? include,
            string assistantId,
            global::G.AnyOf<string, global::G.AssistantSupportedModels?>? model,
            global::G.ReasoningEffort? reasoningEffort,
            string? instructions,
            string? additionalInstructions,
            global::System.Collections.Generic.IList<global::G.CreateMessageRequest>? additionalMessages,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.AssistantToolsCode, global::G.AssistantToolsFileSearch, global::G.AssistantToolsFunction>>? tools,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            double? temperature,
            double? topP,
            bool? stream,
            int? maxPromptTokens,
            int? maxCompletionTokens,
            global::G.AllOf<global::G.TruncationObject, object>? truncationStrategy,
            global::G.AllOf<global::G.AssistantsApiToolChoiceOption?, object>? toolChoice,
            bool? parallelToolCalls,
            global::G.AssistantsApiResponseFormatOption? responseFormat,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.RunObject response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ThreadId { get; } = new(
            name: "threadId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> AssistantId { get; } = new(
            name: "assistantId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.CreateRunIncludeItem>?> Include { get; } = new(
            name: "include")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.AnyOf<string, global::G.AssistantSupportedModels?>?> Model { get; } = new(
            name: "model")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ReasoningEffort?> ReasoningEffort { get; } = new(
            name: "reasoningEffort")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Instructions { get; } = new(
            name: "instructions")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> AdditionalInstructions { get; } = new(
            name: "additionalInstructions")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.CreateMessageRequest>?> AdditionalMessages { get; } = new(
            name: "additionalMessages")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.OneOf<global::G.AssistantToolsCode, global::G.AssistantToolsFileSearch, global::G.AssistantToolsFunction>>?> Tools { get; } = new(
            name: "tools")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.Dictionary<string, string>?> Metadata { get; } = new(
            name: "metadata")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<double?> Temperature { get; } = new(
            name: "temperature")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<double?> TopP { get; } = new(
            name: "topP")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> Stream { get; } = new(
            name: "stream")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> MaxPromptTokens { get; } = new(
            name: "maxPromptTokens")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> MaxCompletionTokens { get; } = new(
            name: "maxCompletionTokens")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.AllOf<global::G.TruncationObject, object>?> TruncationStrategy { get; } = new(
            name: "truncationStrategy")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.AllOf<global::G.AssistantsApiToolChoiceOption?, object>?> ToolChoice { get; } = new(
            name: "toolChoice")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> ParallelToolCalls { get; } = new(
            name: "parallelToolCalls")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.AssistantsApiResponseFormatOption?> ResponseFormat { get; } = new(
            name: "responseFormat")
        {
            Description = "",
        };
        public CreateRunCommand(G.IOpenAiClient client) : base(
            name: "create",
            description: @"")
        {
            _client = client;

            Arguments.Add(ThreadId);
            Arguments.Add(AssistantId);
            Options.Add(Include);
            Options.Add(Model);
            Options.Add(ReasoningEffort);
            Options.Add(Instructions);
            Options.Add(AdditionalInstructions);
            Options.Add(AdditionalMessages);
            Options.Add(Tools);
            Options.Add(Metadata);
            Options.Add(Temperature);
            Options.Add(TopP);
            Options.Add(Stream);
            Options.Add(MaxPromptTokens);
            Options.Add(MaxCompletionTokens);
            Options.Add(TruncationStrategy);
            Options.Add(ToolChoice);
            Options.Add(ParallelToolCalls);
            Options.Add(ResponseFormat);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var threadId = parseResult.GetRequiredValue(ThreadId);
            var include = parseResult.GetRequiredValue(Include);
            var assistantId = parseResult.GetRequiredValue(AssistantId);
            var model = parseResult.GetRequiredValue(Model);
            var reasoningEffort = parseResult.GetRequiredValue(ReasoningEffort);
            var instructions = parseResult.GetRequiredValue(Instructions);
            var additionalInstructions = parseResult.GetRequiredValue(AdditionalInstructions);
            var additionalMessages = parseResult.GetRequiredValue(AdditionalMessages);
            var tools = parseResult.GetRequiredValue(Tools);
            var metadata = parseResult.GetRequiredValue(Metadata);
            var temperature = parseResult.GetRequiredValue(Temperature);
            var topP = parseResult.GetRequiredValue(TopP);
            var stream = parseResult.GetRequiredValue(Stream);
            var maxPromptTokens = parseResult.GetRequiredValue(MaxPromptTokens);
            var maxCompletionTokens = parseResult.GetRequiredValue(MaxCompletionTokens);
            var truncationStrategy = parseResult.GetRequiredValue(TruncationStrategy);
            var toolChoice = parseResult.GetRequiredValue(ToolChoice);
            var parallelToolCalls = parseResult.GetRequiredValue(ParallelToolCalls);
            var responseFormat = parseResult.GetRequiredValue(ResponseFormat);

            Validate(
                parseResult: parseResult,
                threadId: threadId,
                include: include,
                assistantId: assistantId,
                model: model,
                reasoningEffort: reasoningEffort,
                instructions: instructions,
                additionalInstructions: additionalInstructions,
                additionalMessages: additionalMessages,
                tools: tools,
                metadata: metadata,
                temperature: temperature,
                topP: topP,
                stream: stream,
                maxPromptTokens: maxPromptTokens,
                maxCompletionTokens: maxCompletionTokens,
                truncationStrategy: truncationStrategy,
                toolChoice: toolChoice,
                parallelToolCalls: parallelToolCalls,
                responseFormat: responseFormat,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Assistants.CreateRunAsync(
                threadId: threadId,
                include: include,
                assistantId: assistantId,
                model: model,
                reasoningEffort: reasoningEffort,
                instructions: instructions,
                additionalInstructions: additionalInstructions,
                additionalMessages: additionalMessages,
                tools: tools,
                metadata: metadata,
                temperature: temperature,
                topP: topP,
                stream: stream,
                maxPromptTokens: maxPromptTokens,
                maxCompletionTokens: maxCompletionTokens,
                truncationStrategy: truncationStrategy,
                toolChoice: toolChoice,
                parallelToolCalls: parallelToolCalls,
                responseFormat: responseFormat,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}