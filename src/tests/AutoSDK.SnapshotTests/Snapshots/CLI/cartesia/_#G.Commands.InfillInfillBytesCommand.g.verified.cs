//HintName: G.Commands.InfillInfillBytesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class InfillInfillBytesCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.InfillBytesCartesiaVersion cartesiaVersion,
            byte[]? leftAudio,
            string? leftAudioname,
            byte[]? rightAudio,
            string? rightAudioname,
            string? modelId,
            string? language,
            string? transcript,
            string? voiceId,
            global::G.OutputFormat? outputFormat,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            byte[] response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.InfillBytesCartesiaVersion> CartesiaVersion { get; } = new(
            name: "cartesiaVersion")
        {
            Description = @"API version header. Must be set to the API version, e.g. '2024-06-10'.",
        };

        private global::System.CommandLine.Option<byte[]?> LeftAudio { get; } = new(
            name: "leftAudio")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> LeftAudioname { get; } = new(
            name: "leftAudioname")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<byte[]?> RightAudio { get; } = new(
            name: "rightAudio")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> RightAudioname { get; } = new(
            name: "rightAudioname")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> ModelId { get; } = new(
            name: "modelId")
        {
            Description = @"The ID of the model to use for generating audio. Any model other than the first `""sonic""` model is supported.",
        };

        private global::System.CommandLine.Option<string?> Language { get; } = new(
            name: "language")
        {
            Description = @"The language of the transcript",
        };

        private global::System.CommandLine.Option<string?> Transcript { get; } = new(
            name: "transcript")
        {
            Description = @"The infill text to generate",
        };

        private global::System.CommandLine.Option<string?> VoiceId { get; } = new(
            name: "voiceId")
        {
            Description = @"The ID of the voice to use for generating audio",
        };

        private global::System.CommandLine.Option<global::G.OutputFormat?> OutputFormat { get; } = new(
            name: "outputFormat")
        {
            Description = @"",
        };


        public InfillInfillBytesCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "infill",
            description: @"Generate audio that smoothly connects two existing audio segments. This is useful for inserting new speech between existing speech segments while maintaining natural transitions.

**The cost is 1 credit per character of the infill text plus a fixed cost of 300 credits.**

At least one of `left_audio` or `right_audio` must be provided.

As with all generative models, there's some inherent variability, but here's some tips we recommend to get the best results from infill:
- Use longer infill transcripts
  - This gives the model more flexibility to adapt to the rest of the audio
- Target natural pauses in the audio when deciding where to clip
  - This means you don't need word-level timestamps to be as precise
- Clip right up to the start and end of the audio segment you want infilled, keeping as much silence in the left/right audio segments as possible
  - This helps the model generate more natural transitions")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(CartesiaVersion);
            Options.Add(LeftAudio);
            Options.Add(LeftAudioname);
            Options.Add(RightAudio);
            Options.Add(RightAudioname);
            Options.Add(ModelId);
            Options.Add(Language);
            Options.Add(Transcript);
            Options.Add(VoiceId);
            Options.Add(OutputFormat);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var cartesiaVersion = parseResult.GetRequiredValue(CartesiaVersion);
            var leftAudio = parseResult.GetRequiredValue(LeftAudio);
            var leftAudioname = parseResult.GetRequiredValue(LeftAudioname);
            var rightAudio = parseResult.GetRequiredValue(RightAudio);
            var rightAudioname = parseResult.GetRequiredValue(RightAudioname);
            var modelId = parseResult.GetRequiredValue(ModelId);
            var language = parseResult.GetRequiredValue(Language);
            var transcript = parseResult.GetRequiredValue(Transcript);
            var voiceId = parseResult.GetRequiredValue(VoiceId);
            var outputFormat = parseResult.GetRequiredValue(OutputFormat);

            Validate(
                parseResult: parseResult,
                cartesiaVersion: cartesiaVersion,
                leftAudio: leftAudio,
                leftAudioname: leftAudioname,
                rightAudio: rightAudio,
                rightAudioname: rightAudioname,
                modelId: modelId,
                language: language,
                transcript: transcript,
                voiceId: voiceId,
                outputFormat: outputFormat,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Infill.InfillBytesAsync(
                cartesiaVersion: cartesiaVersion,
                leftAudio: leftAudio,
                leftAudioname: leftAudioname,
                rightAudio: rightAudio,
                rightAudioname: rightAudioname,
                modelId: modelId,
                language: language,
                transcript: transcript,
                voiceId: voiceId,
                outputFormat: outputFormat,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}