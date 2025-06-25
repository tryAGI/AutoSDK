//HintName: G.Commands.GetVoiceV1VoicesVoiceIdGetCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetVoiceV1VoicesVoiceIdGetCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string voiceId,
            string? xiApiKey,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.Voice response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> VoiceId { get; } = new(
            name: "voiceId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = @"",
        };
        public GetVoiceV1VoicesVoiceIdGetCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Get a voice by its id")
        {
            _client = client;
            _serviceProvider = serviceProvider;

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
            var response = await _client.GetVoiceV1VoicesVoiceIdGetAsync(
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