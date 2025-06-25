//HintName: G.Commands.AgentsCallsCreateCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AgentsCallsCreateCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

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
            Description = @"",
        };

        private global::System.CommandLine.Option<object?> TemplateContext { get; } = new(
            name: "templateContext")
        {
            Description = @"Context for filling any mustache templates for the call.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.UltravoxV1Message>?> InitialMessages { get; } = new(
            name: "initialMessages")
        {
            Description = @"The conversation history to start from for this call.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.Dictionary<string, string>?> Metadata { get; } = new(
            name: "metadata")
        {
            Description = @"Optional metadata key-value pairs to associate with the call. All values must be strings.
 Keys may not start with ""ultravox."", which is reserved for system-provided metadata.",
        };

        private global::System.CommandLine.Option<global::G.UltravoxV1CallMedium?> Medium { get; } = new(
            name: "medium")
        {
            Description = @"The (overridden) medium used for this call.",
        };

        private global::System.CommandLine.Option<string?> JoinTimeout { get; } = new(
            name: "joinTimeout")
        {
            Description = @"The (overridden) timeout for joining this call.",
        };

        private global::System.CommandLine.Option<string?> MaxDuration { get; } = new(
            name: "maxDuration")
        {
            Description = @"The (overridden) maximum duration of this call.",
        };

        private global::System.CommandLine.Option<bool?> RecordingEnabled { get; } = new(
            name: "recordingEnabled")
        {
            Description = @"The (overridden) setting for whether the call should be recorded.",
        };

        private global::System.CommandLine.Option<global::G.UltravoxV1StartAgentCallRequestInitialOutputMedium?> InitialOutputMedium { get; } = new(
            name: "initialOutputMedium")
        {
            Description = @"The (overridden) medium initially used by the agent. May be altered by the client later.",
        };

        private global::System.CommandLine.Option<global::G.UltravoxV1FirstSpeakerSettings?> FirstSpeakerSettings { get; } = new(
            name: "firstSpeakerSettings")
        {
            Description = @"The (overridden) settings for the initial message to get a conversation started.
 Defaults to `agent: {}` which means the agent will start the conversation with an
 (interruptible) greeting generated based on the system prompt and any initial messages.
 (If first_speaker is set and this is not, first_speaker will be used instead.)",
        };

        private global::System.CommandLine.Option<object?> ExperimentalSettings { get; } = new(
            name: "experimentalSettings")
        {
            Description = @"Experimental settings for the call.",
        };
        public AgentsCallsCreateCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "agents",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

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