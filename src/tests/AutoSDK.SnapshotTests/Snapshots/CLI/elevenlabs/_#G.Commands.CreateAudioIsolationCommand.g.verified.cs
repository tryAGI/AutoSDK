//HintName: G.Commands.CreateAudioIsolationCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateAudioIsolationCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? xiApiKey,
            byte[] audio,
            string audioname,
            global::G.BodyAudioIsolationV1AudioIsolationPostFileFormat? fileFormat,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<byte[]> Audio { get; } = new(
            name: "audio")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Audioname { get; } = new(
            name: "audioname")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.BodyAudioIsolationV1AudioIsolationPostFileFormat?> FileFormat { get; } = new(
            name: "fileFormat")
        {
            Description = "",
        };
        public CreateAudioIsolationCommand(G.IApi client) : base(
            name: "create",
            description: @"Removes background noise from audio")
        {
            _client = client;

            Arguments.Add(Audio);
            Arguments.Add(Audioname);
            Options.Add(XiApiKey);
            Options.Add(FileFormat);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var audio = parseResult.GetRequiredValue(Audio);
            var audioname = parseResult.GetRequiredValue(Audioname);
            var fileFormat = parseResult.GetRequiredValue(FileFormat);

            Validate(
                parseResult: parseResult,
                xiApiKey: xiApiKey,
                audio: audio,
                audioname: audioname,
                fileFormat: fileFormat,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.AudioIsolation.CreateAudioIsolationAsync(
                xiApiKey: xiApiKey,
                audio: audio,
                audioname: audioname,
                fileFormat: fileFormat,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}