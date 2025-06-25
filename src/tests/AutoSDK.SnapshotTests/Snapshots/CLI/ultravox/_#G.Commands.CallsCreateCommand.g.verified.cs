//HintName: G.Commands.CallsCreateCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CallsCreateCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

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
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Guid?> PriorCallId { get; } = new(
            name: "priorCallId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> SystemPrompt { get; } = new(
            name: "systemPrompt")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<float?> Temperature { get; } = new(
            name: "temperature")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Model { get; } = new(
            name: "model")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Voice { get; } = new(
            name: "voice")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.UltravoxV1ExternalVoice?> ExternalVoice { get; } = new(
            name: "externalVoice")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> LanguageHint { get; } = new(
            name: "languageHint")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.UltravoxV1Message>?> InitialMessages { get; } = new(
            name: "initialMessages")
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

        private global::System.CommandLine.Option<string?> TimeExceededMessage { get; } = new(
            name: "timeExceededMessage")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.UltravoxV1TimedMessage>?> InactivityMessages { get; } = new(
            name: "inactivityMessages")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.UltravoxV1SelectedTool>?> SelectedTools { get; } = new(
            name: "selectedTools")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.UltravoxV1CallMedium?> Medium { get; } = new(
            name: "medium")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> RecordingEnabled { get; } = new(
            name: "recordingEnabled")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.UltravoxV1StartCallRequestFirstSpeaker?> FirstSpeaker { get; } = new(
            name: "firstSpeaker")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> TranscriptOptional { get; } = new(
            name: "transcriptOptional")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.UltravoxV1StartCallRequestInitialOutputMedium?> InitialOutputMedium { get; } = new(
            name: "initialOutputMedium")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.UltravoxV1VadSettings?> VadSettings { get; } = new(
            name: "vadSettings")
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

        private global::System.CommandLine.Option<global::System.Collections.Generic.Dictionary<string, string>?> Metadata { get; } = new(
            name: "metadata")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<object?> InitialState { get; } = new(
            name: "initialState")
        {
            Description = "",
        };
        public CallsCreateCommand(G.IApi client) : base(
            name: "calls",
            description: @"")
        {
            _client = client;

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