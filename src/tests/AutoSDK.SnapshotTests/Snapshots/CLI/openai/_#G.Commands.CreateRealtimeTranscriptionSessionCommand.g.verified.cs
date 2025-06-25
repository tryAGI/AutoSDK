//HintName: G.Commands.CreateRealtimeTranscriptionSessionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateRealtimeTranscriptionSessionCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.RealtimeTranscriptionSessionCreateRequestModalitie>? modalities,
            global::G.RealtimeTranscriptionSessionCreateRequestInputAudioFormat? inputAudioFormat,
            global::G.RealtimeTranscriptionSessionCreateRequestInputAudioTranscription? inputAudioTranscription,
            global::G.RealtimeTranscriptionSessionCreateRequestTurnDetection? turnDetection,
            global::G.RealtimeTranscriptionSessionCreateRequestInputAudioNoiseReduction? inputAudioNoiseReduction,
            global::System.Collections.Generic.IList<string>? include,
            global::G.RealtimeTranscriptionSessionCreateRequestClientSecret? clientSecret,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.RealtimeTranscriptionSessionCreateResponse response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.RealtimeTranscriptionSessionCreateRequestModalitie>?> Modalities { get; } = new(
            name: "modalities")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.RealtimeTranscriptionSessionCreateRequestInputAudioFormat?> InputAudioFormat { get; } = new(
            name: "inputAudioFormat")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.RealtimeTranscriptionSessionCreateRequestInputAudioTranscription?> InputAudioTranscription { get; } = new(
            name: "inputAudioTranscription")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.RealtimeTranscriptionSessionCreateRequestTurnDetection?> TurnDetection { get; } = new(
            name: "turnDetection")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.RealtimeTranscriptionSessionCreateRequestInputAudioNoiseReduction?> InputAudioNoiseReduction { get; } = new(
            name: "inputAudioNoiseReduction")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Include { get; } = new(
            name: "include")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.RealtimeTranscriptionSessionCreateRequestClientSecret?> ClientSecret { get; } = new(
            name: "clientSecret")
        {
            Description = "",
        };
        public CreateRealtimeTranscriptionSessionCommand(G.IOpenAiClient client) : base(
            name: "create",
            description: @"")
        {
            _client = client;

            Options.Add(Modalities);
            Options.Add(InputAudioFormat);
            Options.Add(InputAudioTranscription);
            Options.Add(TurnDetection);
            Options.Add(InputAudioNoiseReduction);
            Options.Add(Include);
            Options.Add(ClientSecret);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var modalities = parseResult.GetRequiredValue(Modalities);
            var inputAudioFormat = parseResult.GetRequiredValue(InputAudioFormat);
            var inputAudioTranscription = parseResult.GetRequiredValue(InputAudioTranscription);
            var turnDetection = parseResult.GetRequiredValue(TurnDetection);
            var inputAudioNoiseReduction = parseResult.GetRequiredValue(InputAudioNoiseReduction);
            var include = parseResult.GetRequiredValue(Include);
            var clientSecret = parseResult.GetRequiredValue(ClientSecret);

            Validate(
                parseResult: parseResult,
                modalities: modalities,
                inputAudioFormat: inputAudioFormat,
                inputAudioTranscription: inputAudioTranscription,
                turnDetection: turnDetection,
                inputAudioNoiseReduction: inputAudioNoiseReduction,
                include: include,
                clientSecret: clientSecret,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Realtime.CreateRealtimeTranscriptionSessionAsync(
                modalities: modalities,
                inputAudioFormat: inputAudioFormat,
                inputAudioTranscription: inputAudioTranscription,
                turnDetection: turnDetection,
                inputAudioNoiseReduction: inputAudioNoiseReduction,
                include: include,
                clientSecret: clientSecret,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}