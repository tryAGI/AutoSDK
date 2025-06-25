//HintName: G.Commands.UpdateVoiceV1VoicesVoiceIdEditPostCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UpdateVoiceV1VoicesVoiceIdEditPostCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string voiceId,
            string? xiApiKey,
            string name,
            string description,
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

        private new global::System.CommandLine.Argument<string> Name { get; } = new(
            name: "name")
        {
            Description = @"",
        };

        private new global::System.CommandLine.Argument<string> Description { get; } = new(
            name: "description")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = @"",
        };
        public UpdateVoiceV1VoicesVoiceIdEditPostCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "update",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(VoiceId);
            Arguments.Add(Name);
            Arguments.Add(Description);
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
            var name = parseResult.GetRequiredValue(Name);
            var description = parseResult.GetRequiredValue(Description);

            Validate(
                parseResult: parseResult,
                voiceId: voiceId,
                xiApiKey: xiApiKey,
                name: name,
                description: description,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.UpdateVoiceV1VoicesVoiceIdEditPostAsync(
                voiceId: voiceId,
                xiApiKey: xiApiKey,
                name: name,
                description: description,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}