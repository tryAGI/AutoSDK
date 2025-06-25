//HintName: G.Commands.CreateVoicesPvcByVoiceIdCaptchaCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateVoicesPvcByVoiceIdCaptchaCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string voiceId,
            string? xiApiKey,
            byte[] recording,
            string recordingname,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.VerifyPVCVoiceCaptchaResponseModel response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> VoiceId { get; } = new(
            name: "voiceId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<byte[]> Recording { get; } = new(
            name: "recording")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Recordingname { get; } = new(
            name: "recordingname")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };
        public CreateVoicesPvcByVoiceIdCaptchaCommand(G.IApi client) : base(
            name: "create",
            description: @"Submit captcha verification for PVC voice.")
        {
            _client = client;

            Arguments.Add(VoiceId);
            Arguments.Add(Recording);
            Arguments.Add(Recordingname);
            Options.Add(XiApiKey);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var voiceId = parseResult.GetRequiredValue(VoiceId);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var recording = parseResult.GetRequiredValue(Recording);
            var recordingname = parseResult.GetRequiredValue(Recordingname);

            Validate(
                parseResult: parseResult,
                voiceId: voiceId,
                xiApiKey: xiApiKey,
                recording: recording,
                recordingname: recordingname,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.PvcVoices.CreateVoicesPvcByVoiceIdCaptchaAsync(
                voiceId: voiceId,
                xiApiKey: xiApiKey,
                recording: recording,
                recordingname: recordingname,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}