//HintName: G.Commands.GetVoicesByVoiceIdSettingsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetVoicesByVoiceIdSettingsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string voiceId,
            string? xiApiKey,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.VoiceSettingsResponseModel response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> VoiceId { get; } = new(
            name: "voiceId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };
        public GetVoicesByVoiceIdSettingsCommand(G.IApi client) : base(
            name: "get",
            description: @"Returns the settings for a specific voice. ""similarity_boost"" corresponds to""Clarity + Similarity Enhancement"" in the web app and ""stability"" corresponds to ""Stability"" slider in the web app.")
        {
            _client = client;

            Arguments.Add(VoiceId);
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

            Validate(
                parseResult: parseResult,
                voiceId: voiceId,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Voices.GetVoicesByVoiceIdSettingsAsync(
                voiceId: voiceId,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}