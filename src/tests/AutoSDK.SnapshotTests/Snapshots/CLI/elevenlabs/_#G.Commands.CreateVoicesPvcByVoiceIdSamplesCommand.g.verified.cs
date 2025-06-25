//HintName: G.Commands.CreateVoicesPvcByVoiceIdSamplesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateVoicesPvcByVoiceIdSamplesCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string voiceId,
            string? xiApiKey,
            global::System.Collections.Generic.IList<byte[]> files,
            bool? removeBackgroundNoise,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.SampleResponseModel> response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> VoiceId { get; } = new(
            name: "voiceId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<byte[]>> Files { get; } = new(
            name: "files")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> RemoveBackgroundNoise { get; } = new(
            name: "removeBackgroundNoise")
        {
            Description = "",
        };
        public CreateVoicesPvcByVoiceIdSamplesCommand(G.IApi client) : base(
            name: "create",
            description: @"Add audio samples to a PVC voice")
        {
            _client = client;

            Arguments.Add(VoiceId);
            Arguments.Add(Files);
            Options.Add(XiApiKey);
            Options.Add(RemoveBackgroundNoise);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var voiceId = parseResult.GetRequiredValue(VoiceId);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var files = parseResult.GetRequiredValue(Files);
            var removeBackgroundNoise = parseResult.GetRequiredValue(RemoveBackgroundNoise);

            Validate(
                parseResult: parseResult,
                voiceId: voiceId,
                xiApiKey: xiApiKey,
                files: files,
                removeBackgroundNoise: removeBackgroundNoise,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.PvcVoices.CreateVoicesPvcByVoiceIdSamplesAsync(
                voiceId: voiceId,
                xiApiKey: xiApiKey,
                files: files,
                removeBackgroundNoise: removeBackgroundNoise,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}