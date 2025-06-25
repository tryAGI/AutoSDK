//HintName: G.Commands.AgentsCallsCreateCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AgentsCallsCreateCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid agentId,
            object? templateContext,
            global::System.Collections.Generic.IList<global::G.UltravoxV1Message>? initialMessages,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            global::G.UltravoxV1CallMedium? medium,
            string? joinTimeout,
            string? maxDuration,
            bool? recordingEnabled,
            global::G.UltravoxV1StartAgentCallRequestInitialOutputMedium? initialOutputMedium,
            global::G.UltravoxV1FirstSpeakerSettings? firstSpeakerSettings,
            object? experimentalSettings,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.Call response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> AgentId { get; } = new(
            name: "agentId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<object?> TemplateContext { get; } = new(
            name: "templateContext")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.UltravoxV1Message>?> InitialMessages { get; } = new(
            name: "initialMessages")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.Dictionary<string, string>?> Metadata { get; } = new(
            name: "metadata")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.UltravoxV1CallMedium?> Medium { get; } = new(
            name: "medium")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> JoinTimeout { get; } = new(
            name: "joinTimeout")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> MaxDuration { get; } = new(
            name: "maxDuration")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> RecordingEnabled { get; } = new(
            name: "recordingEnabled")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.UltravoxV1StartAgentCallRequestInitialOutputMedium?> InitialOutputMedium { get; } = new(
            name: "initialOutputMedium")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.UltravoxV1FirstSpeakerSettings?> FirstSpeakerSettings { get; } = new(
            name: "firstSpeakerSettings")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<object?> ExperimentalSettings { get; } = new(
            name: "experimentalSettings")
        {
            Description = "",
        };
        public AgentsCallsCreateCommand(G.IApi client) : base(
            name: "agents",
            description: @"")
        {
            _client = client;

            Arguments.Add(AgentId);
            Options.Add(TemplateContext);
            Options.Add(InitialMessages);
            Options.Add(Metadata);
            Options.Add(Medium);
            Options.Add(JoinTimeout);
            Options.Add(MaxDuration);
            Options.Add(RecordingEnabled);
            Options.Add(InitialOutputMedium);
            Options.Add(FirstSpeakerSettings);
            Options.Add(ExperimentalSettings);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var agentId = parseResult.GetRequiredValue(AgentId);
            var templateContext = parseResult.GetRequiredValue(TemplateContext);
            var initialMessages = parseResult.GetRequiredValue(InitialMessages);
            var metadata = parseResult.GetRequiredValue(Metadata);
            var medium = parseResult.GetRequiredValue(Medium);
            var joinTimeout = parseResult.GetRequiredValue(JoinTimeout);
            var maxDuration = parseResult.GetRequiredValue(MaxDuration);
            var recordingEnabled = parseResult.GetRequiredValue(RecordingEnabled);
            var initialOutputMedium = parseResult.GetRequiredValue(InitialOutputMedium);
            var firstSpeakerSettings = parseResult.GetRequiredValue(FirstSpeakerSettings);
            var experimentalSettings = parseResult.GetRequiredValue(ExperimentalSettings);

            Validate(
                parseResult: parseResult,
                agentId: agentId,
                templateContext: templateContext,
                initialMessages: initialMessages,
                metadata: metadata,
                medium: medium,
                joinTimeout: joinTimeout,
                maxDuration: maxDuration,
                recordingEnabled: recordingEnabled,
                initialOutputMedium: initialOutputMedium,
                firstSpeakerSettings: firstSpeakerSettings,
                experimentalSettings: experimentalSettings,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Agents.AgentsCallsCreateAsync(
                agentId: agentId,
                templateContext: templateContext,
                initialMessages: initialMessages,
                metadata: metadata,
                medium: medium,
                joinTimeout: joinTimeout,
                maxDuration: maxDuration,
                recordingEnabled: recordingEnabled,
                initialOutputMedium: initialOutputMedium,
                firstSpeakerSettings: firstSpeakerSettings,
                experimentalSettings: experimentalSettings,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}