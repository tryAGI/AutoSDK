//HintName: G.Commands.AudioCreateSpeechCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AudioCreateSpeechCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.AnyOf<string, global::G.CreateSpeechRequestModel?> model,
            string input,
            string voice,
            global::G.CreateSpeechRequestResponseFormat? responseFormat,
            int? sampleRate,
            double? speed,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            byte[] response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.AnyOf<string, global::G.CreateSpeechRequestModel?>> Model { get; } = new(
            name: "model")
        {
            Description = @"One of the [available TTS models](/docs/text-to-speech).",
        };

        private global::System.CommandLine.Argument<string> Input { get; } = new(
            name: "input")
        {
            Description = @"The text to generate audio for.",
        };

        private global::System.CommandLine.Argument<string> Voice { get; } = new(
            name: "voice")
        {
            Description = @"The voice to use when generating the audio. List of voices can be found [here](/docs/text-to-speech).",
        };

        private global::System.CommandLine.Option<global::G.CreateSpeechRequestResponseFormat?> ResponseFormat { get; } = new(
            name: "responseFormat")
        {
            Description = @"The format of the generated audio. Supported formats are `flac, mp3, mulaw, ogg, wav`.",
        };

        private global::System.CommandLine.Option<int?> SampleRate { get; } = new(
            name: "sampleRate")
        {
            Description = @"The sample rate for generated audio",
        };

        private global::System.CommandLine.Option<double?> Speed { get; } = new(
            name: "speed")
        {
            Description = @"The speed of the generated audio.",
        };


        public AudioCreateSpeechCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Model);
            Arguments.Add(Input);
            Arguments.Add(Voice);
            Options.Add(ResponseFormat);
            Options.Add(SampleRate);
            Options.Add(Speed);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var model = parseResult.GetRequiredValue(Model);
            var input = parseResult.GetRequiredValue(Input);
            var voice = parseResult.GetRequiredValue(Voice);
            var responseFormat = parseResult.GetRequiredValue(ResponseFormat);
            var sampleRate = parseResult.GetRequiredValue(SampleRate);
            var speed = parseResult.GetRequiredValue(Speed);

            Validate(
                parseResult: parseResult,
                model: model,
                input: input,
                voice: voice,
                responseFormat: responseFormat,
                sampleRate: sampleRate,
                speed: speed,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Audio.CreateSpeechAsync(
                model: model,
                input: input,
                voice: voice,
                responseFormat: responseFormat,
                sampleRate: sampleRate,
                speed: speed,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}