//HintName: G.Commands.VoicesRetrieveCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class VoicesRetrieveCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid voiceId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.Voice response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> VoiceId { get; } = new(
            name: "voiceId")
        {
            Description = "",
        };

        public VoicesRetrieveCommand(G.IApi client) : base(
            name: "voices",
            description: @"")
        {
            _client = client;

            Arguments.Add(VoiceId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var voiceId = parseResult.GetRequiredValue(VoiceId);

            Validate(
                parseResult: parseResult,
                voiceId: voiceId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Voices.VoicesRetrieveAsync(
                voiceId: voiceId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}