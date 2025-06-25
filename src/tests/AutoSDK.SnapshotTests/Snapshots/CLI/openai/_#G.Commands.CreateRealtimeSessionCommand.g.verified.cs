//HintName: G.Commands.CreateRealtimeSessionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateRealtimeSessionCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.RealtimeSessionCreateRequestModalitie>? modalities,
            global::G.RealtimeSessionCreateRequestModel? model,
            string? instructions,
            global::G.VoiceIdsShared? voice,
            global::G.RealtimeSessionCreateRequestInputAudioFormat? inputAudioFormat,
            global::G.RealtimeSessionCreateRequestOutputAudioFormat? outputAudioFormat,
            global::G.RealtimeSessionCreateRequestInputAudioTranscription? inputAudioTranscription,
            global::G.RealtimeSessionCreateRequestTurnDetection? turnDetection,
            global::G.RealtimeSessionCreateRequestInputAudioNoiseReduction? inputAudioNoiseReduction,
            double? speed,
            global::G.OneOf<global::G.RealtimeSessionCreateRequestTracingEnum?, global::G.RealtimeSessionCreateRequestTracingEnum2>? tracing,
            global::System.Collections.Generic.IList<global::G.RealtimeSessionCreateRequestTool>? tools,
            string? toolChoice,
            double? temperature,
            global::G.OneOf<int?, global::G.RealtimeSessionCreateRequestMaxResponseOutputTokens?>? maxResponseOutputTokens,
            global::G.RealtimeSessionCreateRequestClientSecret? clientSecret,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.RealtimeSessionCreateResponse response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.RealtimeSessionCreateRequestModalitie>?> Modalities { get; } = new(
            name: "modalities")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.RealtimeSessionCreateRequestModel?> Model { get; } = new(
            name: "model")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Instructions { get; } = new(
            name: "instructions")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.VoiceIdsShared?> Voice { get; } = new(
            name: "voice")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.RealtimeSessionCreateRequestInputAudioFormat?> InputAudioFormat { get; } = new(
            name: "inputAudioFormat")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.RealtimeSessionCreateRequestOutputAudioFormat?> OutputAudioFormat { get; } = new(
            name: "outputAudioFormat")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.RealtimeSessionCreateRequestInputAudioTranscription?> InputAudioTranscription { get; } = new(
            name: "inputAudioTranscription")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.RealtimeSessionCreateRequestTurnDetection?> TurnDetection { get; } = new(
            name: "turnDetection")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.RealtimeSessionCreateRequestInputAudioNoiseReduction?> InputAudioNoiseReduction { get; } = new(
            name: "inputAudioNoiseReduction")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<double?> Speed { get; } = new(
            name: "speed")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.OneOf<global::G.RealtimeSessionCreateRequestTracingEnum?, global::G.RealtimeSessionCreateRequestTracingEnum2>?> Tracing { get; } = new(
            name: "tracing")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.RealtimeSessionCreateRequestTool>?> Tools { get; } = new(
            name: "tools")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> ToolChoice { get; } = new(
            name: "toolChoice")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<double?> Temperature { get; } = new(
            name: "temperature")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.OneOf<int?, global::G.RealtimeSessionCreateRequestMaxResponseOutputTokens?>?> MaxResponseOutputTokens { get; } = new(
            name: "maxResponseOutputTokens")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.RealtimeSessionCreateRequestClientSecret?> ClientSecret { get; } = new(
            name: "clientSecret")
        {
            Description = "",
        };
        public CreateRealtimeSessionCommand(G.IOpenAiClient client) : base(
            name: "create",
            description: @"")
        {
            _client = client;

            Options.Add(Modalities);
            Options.Add(Model);
            Options.Add(Instructions);
            Options.Add(Voice);
            Options.Add(InputAudioFormat);
            Options.Add(OutputAudioFormat);
            Options.Add(InputAudioTranscription);
            Options.Add(TurnDetection);
            Options.Add(InputAudioNoiseReduction);
            Options.Add(Speed);
            Options.Add(Tracing);
            Options.Add(Tools);
            Options.Add(ToolChoice);
            Options.Add(Temperature);
            Options.Add(MaxResponseOutputTokens);
            Options.Add(ClientSecret);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var modalities = parseResult.GetRequiredValue(Modalities);
            var model = parseResult.GetRequiredValue(Model);
            var instructions = parseResult.GetRequiredValue(Instructions);
            var voice = parseResult.GetRequiredValue(Voice);
            var inputAudioFormat = parseResult.GetRequiredValue(InputAudioFormat);
            var outputAudioFormat = parseResult.GetRequiredValue(OutputAudioFormat);
            var inputAudioTranscription = parseResult.GetRequiredValue(InputAudioTranscription);
            var turnDetection = parseResult.GetRequiredValue(TurnDetection);
            var inputAudioNoiseReduction = parseResult.GetRequiredValue(InputAudioNoiseReduction);
            var speed = parseResult.GetRequiredValue(Speed);
            var tracing = parseResult.GetRequiredValue(Tracing);
            var tools = parseResult.GetRequiredValue(Tools);
            var toolChoice = parseResult.GetRequiredValue(ToolChoice);
            var temperature = parseResult.GetRequiredValue(Temperature);
            var maxResponseOutputTokens = parseResult.GetRequiredValue(MaxResponseOutputTokens);
            var clientSecret = parseResult.GetRequiredValue(ClientSecret);

            Validate(
                parseResult: parseResult,
                modalities: modalities,
                model: model,
                instructions: instructions,
                voice: voice,
                inputAudioFormat: inputAudioFormat,
                outputAudioFormat: outputAudioFormat,
                inputAudioTranscription: inputAudioTranscription,
                turnDetection: turnDetection,
                inputAudioNoiseReduction: inputAudioNoiseReduction,
                speed: speed,
                tracing: tracing,
                tools: tools,
                toolChoice: toolChoice,
                temperature: temperature,
                maxResponseOutputTokens: maxResponseOutputTokens,
                clientSecret: clientSecret,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Realtime.CreateRealtimeSessionAsync(
                modalities: modalities,
                model: model,
                instructions: instructions,
                voice: voice,
                inputAudioFormat: inputAudioFormat,
                outputAudioFormat: outputAudioFormat,
                inputAudioTranscription: inputAudioTranscription,
                turnDetection: turnDetection,
                inputAudioNoiseReduction: inputAudioNoiseReduction,
                speed: speed,
                tracing: tracing,
                tools: tools,
                toolChoice: toolChoice,
                temperature: temperature,
                maxResponseOutputTokens: maxResponseOutputTokens,
                clientSecret: clientSecret,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}