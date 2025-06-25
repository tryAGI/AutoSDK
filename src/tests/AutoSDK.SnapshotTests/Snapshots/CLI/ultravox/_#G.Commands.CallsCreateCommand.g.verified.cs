//HintName: G.Commands.CallsCreateCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CallsCreateCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            bool? enableGreetingPrompt,
            global::System.Guid? priorCallId,
            string? systemPrompt,
            float? temperature,
            string? model,
            string? voice,
            global::G.UltravoxV1ExternalVoice? externalVoice,
            string? languageHint,
            global::System.Collections.Generic.IList<global::G.UltravoxV1Message>? initialMessages,
            string? joinTimeout,
            string? maxDuration,
            string? timeExceededMessage,
            global::System.Collections.Generic.IList<global::G.UltravoxV1TimedMessage>? inactivityMessages,
            global::System.Collections.Generic.IList<global::G.UltravoxV1SelectedTool>? selectedTools,
            global::G.UltravoxV1CallMedium? medium,
            bool? recordingEnabled,
            global::G.UltravoxV1StartCallRequestFirstSpeaker? firstSpeaker,
            bool? transcriptOptional,
            global::G.UltravoxV1StartCallRequestInitialOutputMedium? initialOutputMedium,
            global::G.UltravoxV1VadSettings? vadSettings,
            global::G.UltravoxV1FirstSpeakerSettings? firstSpeakerSettings,
            object? experimentalSettings,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            object? initialState,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.Call response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<bool?> EnableGreetingPrompt { get; } = new(
            name: "enableGreetingPrompt")
        {
            Description = @"Adds a prompt for a greeting if there's not an initial message that the model would naturally respond to (a user message or tool result).",
        };

        private global::System.CommandLine.Option<global::System.Guid?> PriorCallId { get; } = new(
            name: "priorCallId")
        {
            Description = @"The UUID of a prior call. When specified, the new call will use the same properites as the prior call unless overriden in this request's body. The new call will also use the prior call's message history as its own initial_messages. (It's illegal to also set initial_messages in the body.)",
        };

        private global::System.CommandLine.Option<string?> SystemPrompt { get; } = new(
            name: "systemPrompt")
        {
            Description = @"The system prompt provided to the model during generations.",
        };

        private global::System.CommandLine.Option<float?> Temperature { get; } = new(
            name: "temperature")
        {
            Description = @"The model temperature, between 0 and 1. Defaults to 0.",
        };

        private global::System.CommandLine.Option<string?> Model { get; } = new(
            name: "model")
        {
            Description = @"The model used for generations. Defaults to fixie-ai/ultravox.",
        };

        private global::System.CommandLine.Option<string?> Voice { get; } = new(
            name: "voice")
        {
            Description = @"The ID (or name if unique) of the voice the agent should use for this call.",
        };

        private global::System.CommandLine.Option<global::G.UltravoxV1ExternalVoice?> ExternalVoice { get; } = new(
            name: "externalVoice")
        {
            Description = @"A voice not known to Ultravox Realtime that can nonetheless be used for this call.
 Your account must have an API key set for the provider of the voice.
 Either this or `voice` may be set, but not both.",
        };

        private global::System.CommandLine.Option<string?> LanguageHint { get; } = new(
            name: "languageHint")
        {
            Description = @"A BCP47 language code that may be used to guide speech recognition and synthesis.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.UltravoxV1Message>?> InitialMessages { get; } = new(
            name: "initialMessages")
        {
            Description = @"The conversation history to start from for this call.",
        };

        private global::System.CommandLine.Option<string?> JoinTimeout { get; } = new(
            name: "joinTimeout")
        {
            Description = @"A timeout for joining the call. Defaults to 30 seconds.",
        };

        private global::System.CommandLine.Option<string?> MaxDuration { get; } = new(
            name: "maxDuration")
        {
            Description = @"The maximum duration of the call. Defaults to 1 hour.",
        };

        private global::System.CommandLine.Option<string?> TimeExceededMessage { get; } = new(
            name: "timeExceededMessage")
        {
            Description = @"What the agent should say immediately before hanging up if the call's time limit is reached.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.UltravoxV1TimedMessage>?> InactivityMessages { get; } = new(
            name: "inactivityMessages")
        {
            Description = @"Messages spoken by the agent when the user is inactive for the specified duration.
 Durations are cumulative, so a message m > 1 with duration 30s will be spoken 30 seconds after message m-1.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.UltravoxV1SelectedTool>?> SelectedTools { get; } = new(
            name: "selectedTools")
        {
            Description = @"The tools available to the agent for (the first stage of) this call.",
        };

        private global::System.CommandLine.Option<global::G.UltravoxV1CallMedium?> Medium { get; } = new(
            name: "medium")
        {
            Description = @"The medium used for this call.",
        };

        private global::System.CommandLine.Option<bool?> RecordingEnabled { get; } = new(
            name: "recordingEnabled")
        {
            Description = @"Whether the call should be recorded.",
        };

        private global::System.CommandLine.Option<global::G.UltravoxV1StartCallRequestFirstSpeaker?> FirstSpeaker { get; } = new(
            name: "firstSpeaker")
        {
            Description = @"Who should talk first when the call starts. Typically set to FIRST_SPEAKER_USER for outgoing
 calls and left as the default (FIRST_SPEAKER_AGENT) otherwise.
 Deprecated. Prefer `firstSpeakerSettings`. If both are set, they must match.",
        };

        private global::System.CommandLine.Option<bool?> TranscriptOptional { get; } = new(
            name: "transcriptOptional")
        {
            Description = @"Indicates whether a transcript is optional for the call.",
        };

        private global::System.CommandLine.Option<global::G.UltravoxV1StartCallRequestInitialOutputMedium?> InitialOutputMedium { get; } = new(
            name: "initialOutputMedium")
        {
            Description = @"The medium to use for the call initially. May be altered by the client later.
 Defaults to voice.",
        };

        private global::System.CommandLine.Option<global::G.UltravoxV1VadSettings?> VadSettings { get; } = new(
            name: "vadSettings")
        {
            Description = @"VAD settings for the call.",
        };

        private global::System.CommandLine.Option<global::G.UltravoxV1FirstSpeakerSettings?> FirstSpeakerSettings { get; } = new(
            name: "firstSpeakerSettings")
        {
            Description = @"The settings for the initial message to get a conversation started.
 Defaults to `agent: {}` which means the agent will start the conversation with an
 (interruptible) greeting generated based on the system prompt and any initial messages.
 (If first_speaker is set and this is not, first_speaker will be used instead.)",
        };

        private global::System.CommandLine.Option<object?> ExperimentalSettings { get; } = new(
            name: "experimentalSettings")
        {
            Description = @"Experimental settings for the call.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.Dictionary<string, string>?> Metadata { get; } = new(
            name: "metadata")
        {
            Description = @"Optional metadata key-value pairs to associate with the call. All values must be strings.
 Keys may not start with ""ultravox."", which is reserved for system-provided metadata.",
        };

        private global::System.CommandLine.Option<object?> InitialState { get; } = new(
            name: "initialState")
        {
            Description = @"The initial state of the call stage which is readable/writable by tools.",
        };
        public CallsCreateCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "calls",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(EnableGreetingPrompt);
            Options.Add(PriorCallId);
            Options.Add(SystemPrompt);
            Options.Add(Temperature);
            Options.Add(Model);
            Options.Add(Voice);
            Options.Add(ExternalVoice);
            Options.Add(LanguageHint);
            Options.Add(InitialMessages);
            Options.Add(JoinTimeout);
            Options.Add(MaxDuration);
            Options.Add(TimeExceededMessage);
            Options.Add(InactivityMessages);
            Options.Add(SelectedTools);
            Options.Add(Medium);
            Options.Add(RecordingEnabled);
            Options.Add(FirstSpeaker);
            Options.Add(TranscriptOptional);
            Options.Add(InitialOutputMedium);
            Options.Add(VadSettings);
            Options.Add(FirstSpeakerSettings);
            Options.Add(ExperimentalSettings);
            Options.Add(Metadata);
            Options.Add(InitialState);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var enableGreetingPrompt = parseResult.GetRequiredValue(EnableGreetingPrompt);
            var priorCallId = parseResult.GetRequiredValue(PriorCallId);
            var systemPrompt = parseResult.GetRequiredValue(SystemPrompt);
            var temperature = parseResult.GetRequiredValue(Temperature);
            var model = parseResult.GetRequiredValue(Model);
            var voice = parseResult.GetRequiredValue(Voice);
            var externalVoice = parseResult.GetRequiredValue(ExternalVoice);
            var languageHint = parseResult.GetRequiredValue(LanguageHint);
            var initialMessages = parseResult.GetRequiredValue(InitialMessages);
            var joinTimeout = parseResult.GetRequiredValue(JoinTimeout);
            var maxDuration = parseResult.GetRequiredValue(MaxDuration);
            var timeExceededMessage = parseResult.GetRequiredValue(TimeExceededMessage);
            var inactivityMessages = parseResult.GetRequiredValue(InactivityMessages);
            var selectedTools = parseResult.GetRequiredValue(SelectedTools);
            var medium = parseResult.GetRequiredValue(Medium);
            var recordingEnabled = parseResult.GetRequiredValue(RecordingEnabled);
            var firstSpeaker = parseResult.GetRequiredValue(FirstSpeaker);
            var transcriptOptional = parseResult.GetRequiredValue(TranscriptOptional);
            var initialOutputMedium = parseResult.GetRequiredValue(InitialOutputMedium);
            var vadSettings = parseResult.GetRequiredValue(VadSettings);
            var firstSpeakerSettings = parseResult.GetRequiredValue(FirstSpeakerSettings);
            var experimentalSettings = parseResult.GetRequiredValue(ExperimentalSettings);
            var metadata = parseResult.GetRequiredValue(Metadata);
            var initialState = parseResult.GetRequiredValue(InitialState);

            Validate(
                parseResult: parseResult,
                enableGreetingPrompt: enableGreetingPrompt,
                priorCallId: priorCallId,
                systemPrompt: systemPrompt,
                temperature: temperature,
                model: model,
                voice: voice,
                externalVoice: externalVoice,
                languageHint: languageHint,
                initialMessages: initialMessages,
                joinTimeout: joinTimeout,
                maxDuration: maxDuration,
                timeExceededMessage: timeExceededMessage,
                inactivityMessages: inactivityMessages,
                selectedTools: selectedTools,
                medium: medium,
                recordingEnabled: recordingEnabled,
                firstSpeaker: firstSpeaker,
                transcriptOptional: transcriptOptional,
                initialOutputMedium: initialOutputMedium,
                vadSettings: vadSettings,
                firstSpeakerSettings: firstSpeakerSettings,
                experimentalSettings: experimentalSettings,
                metadata: metadata,
                initialState: initialState,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Calls.CallsCreateAsync(
                enableGreetingPrompt: enableGreetingPrompt,
                priorCallId: priorCallId,
                systemPrompt: systemPrompt,
                temperature: temperature,
                model: model,
                voice: voice,
                externalVoice: externalVoice,
                languageHint: languageHint,
                initialMessages: initialMessages,
                joinTimeout: joinTimeout,
                maxDuration: maxDuration,
                timeExceededMessage: timeExceededMessage,
                inactivityMessages: inactivityMessages,
                selectedTools: selectedTools,
                medium: medium,
                recordingEnabled: recordingEnabled,
                firstSpeaker: firstSpeaker,
                transcriptOptional: transcriptOptional,
                initialOutputMedium: initialOutputMedium,
                vadSettings: vadSettings,
                firstSpeakerSettings: firstSpeakerSettings,
                experimentalSettings: experimentalSettings,
                metadata: metadata,
                initialState: initialState,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}