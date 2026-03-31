//HintName: G.Commands.VoiceChangerVoiceChangerSseCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class VoiceChangerVoiceChangerSseCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.VoiceChangerSseCartesiaVersion cartesiaVersion,
            byte[]? clip,
            string? clipname,
            string? voiceId,
            global::G.OutputFormatContainer? outputFormatContainer,
            int? outputFormatSampleRate,
            global::G.RawEncoding? outputFormatEncoding,
            int? outputFormatBitRate,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.VoiceChangerSseCartesiaVersion> CartesiaVersion { get; } = new(
            name: "cartesiaVersion")
        {
            Description = @"API version header. Must be set to the API version, e.g. '2024-06-10'.",
        };

        private global::System.CommandLine.Option<byte[]?> Clip { get; } = new(
            name: "clip")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Clipname { get; } = new(
            name: "clipname")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> VoiceId { get; } = new(
            name: "voiceId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.OutputFormatContainer?> OutputFormatContainer { get; } = new(
            name: "outputFormatContainer")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> OutputFormatSampleRate { get; } = new(
            name: "outputFormatSampleRate")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.RawEncoding?> OutputFormatEncoding { get; } = new(
            name: "outputFormatEncoding")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> OutputFormatBitRate { get; } = new(
            name: "outputFormatBitRate")
        {
            Description = @"Required for `mp3` containers.",
        };


        public VoiceChangerVoiceChangerSseCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "voice",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(CartesiaVersion);
            Options.Add(Clip);
            Options.Add(Clipname);
            Options.Add(VoiceId);
            Options.Add(OutputFormatContainer);
            Options.Add(OutputFormatSampleRate);
            Options.Add(OutputFormatEncoding);
            Options.Add(OutputFormatBitRate);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var cartesiaVersion = parseResult.GetRequiredValue(CartesiaVersion);
            var clip = parseResult.GetRequiredValue(Clip);
            var clipname = parseResult.GetRequiredValue(Clipname);
            var voiceId = parseResult.GetRequiredValue(VoiceId);
            var outputFormatContainer = parseResult.GetRequiredValue(OutputFormatContainer);
            var outputFormatSampleRate = parseResult.GetRequiredValue(OutputFormatSampleRate);
            var outputFormatEncoding = parseResult.GetRequiredValue(OutputFormatEncoding);
            var outputFormatBitRate = parseResult.GetRequiredValue(OutputFormatBitRate);

            Validate(
                parseResult: parseResult,
                cartesiaVersion: cartesiaVersion,
                clip: clip,
                clipname: clipname,
                voiceId: voiceId,
                outputFormatContainer: outputFormatContainer,
                outputFormatSampleRate: outputFormatSampleRate,
                outputFormatEncoding: outputFormatEncoding,
                outputFormatBitRate: outputFormatBitRate,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.VoiceChanger.VoiceChangerSseAsync(
                cartesiaVersion: cartesiaVersion,
                clip: clip,
                clipname: clipname,
                voiceId: voiceId,
                outputFormatContainer: outputFormatContainer,
                outputFormatSampleRate: outputFormatSampleRate,
                outputFormatEncoding: outputFormatEncoding,
                outputFormatBitRate: outputFormatBitRate,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}