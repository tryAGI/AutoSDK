//HintName: G.Commands.ModifyAssistantCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ModifyAssistantCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string assistantId,
            global::G.AnyOf<string, global::G.AssistantSupportedModels?>? model,
            global::G.ReasoningEffort? reasoningEffort,
            string? name,
            string? description,
            string? instructions,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.AssistantToolsCode, global::G.AssistantToolsFileSearch, global::G.AssistantToolsFunction>>? tools,
            global::G.ModifyAssistantRequestToolResources? toolResources,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            double? temperature,
            double? topP,
            global::G.AssistantsApiResponseFormatOption? responseFormat,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.AssistantObject response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> AssistantId { get; } = new(
            name: "assistantId")
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

        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = "",
        };

        private new global::System.CommandLine.Option<string?> Description { get; } = new(
            name: "description")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Instructions { get; } = new(
            name: "instructions")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.OneOf<global::G.AssistantToolsCode, global::G.AssistantToolsFileSearch, global::G.AssistantToolsFunction>>?> Tools { get; } = new(
            name: "tools")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ModifyAssistantRequestToolResources?> ToolResources { get; } = new(
            name: "toolResources")
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

        private global::System.CommandLine.Option<global::G.AssistantsApiResponseFormatOption?> ResponseFormat { get; } = new(
            name: "responseFormat")
        {
            Description = "",
        };
        public ModifyAssistantCommand(G.IOpenAiClient client) : base(
            name: "modify",
            description: @"")
        {
            _client = client;

            Arguments.Add(AssistantId);
            Options.Add(Model);
            Options.Add(ReasoningEffort);
            Options.Add(Name);
            Options.Add(Description);
            Options.Add(Instructions);
            Options.Add(Tools);
            Options.Add(ToolResources);
            Options.Add(Metadata);
            Options.Add(Temperature);
            Options.Add(TopP);
            Options.Add(ResponseFormat);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var assistantId = parseResult.GetRequiredValue(AssistantId);
            var model = parseResult.GetRequiredValue(Model);
            var reasoningEffort = parseResult.GetRequiredValue(ReasoningEffort);
            var name = parseResult.GetRequiredValue(Name);
            var description = parseResult.GetRequiredValue(Description);
            var instructions = parseResult.GetRequiredValue(Instructions);
            var tools = parseResult.GetRequiredValue(Tools);
            var toolResources = parseResult.GetRequiredValue(ToolResources);
            var metadata = parseResult.GetRequiredValue(Metadata);
            var temperature = parseResult.GetRequiredValue(Temperature);
            var topP = parseResult.GetRequiredValue(TopP);
            var responseFormat = parseResult.GetRequiredValue(ResponseFormat);

            Validate(
                parseResult: parseResult,
                assistantId: assistantId,
                model: model,
                reasoningEffort: reasoningEffort,
                name: name,
                description: description,
                instructions: instructions,
                tools: tools,
                toolResources: toolResources,
                metadata: metadata,
                temperature: temperature,
                topP: topP,
                responseFormat: responseFormat,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Assistants.ModifyAssistantAsync(
                assistantId: assistantId,
                model: model,
                reasoningEffort: reasoningEffort,
                name: name,
                description: description,
                instructions: instructions,
                tools: tools,
                toolResources: toolResources,
                metadata: metadata,
                temperature: temperature,
                topP: topP,
                responseFormat: responseFormat,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}