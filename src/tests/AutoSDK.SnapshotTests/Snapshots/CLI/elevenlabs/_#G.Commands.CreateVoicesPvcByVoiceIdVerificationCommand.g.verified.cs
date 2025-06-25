//HintName: G.Commands.CreateVoicesPvcByVoiceIdVerificationCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateVoicesPvcByVoiceIdVerificationCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string voiceId,
            string? xiApiKey,
            global::System.Collections.Generic.IList<byte[]> files,
            string? extraText,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.RequestPVCManualVerificationResponseModel response,
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

        private global::System.CommandLine.Option<string?> ExtraText { get; } = new(
            name: "extraText")
        {
            Description = "",
        };
        public CreateVoicesPvcByVoiceIdVerificationCommand(G.IApi client) : base(
            name: "create",
            description: @"Request manual verification for a PVC voice.")
        {
            _client = client;

            Arguments.Add(VoiceId);
            Arguments.Add(Files);
            Options.Add(XiApiKey);
            Options.Add(ExtraText);

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
            var extraText = parseResult.GetRequiredValue(ExtraText);

            Validate(
                parseResult: parseResult,
                voiceId: voiceId,
                xiApiKey: xiApiKey,
                files: files,
                extraText: extraText,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.PvcVoices.CreateVoicesPvcByVoiceIdVerificationAsync(
                voiceId: voiceId,
                xiApiKey: xiApiKey,
                files: files,
                extraText: extraText,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}