//HintName: G.Commands.VoicesDestroyCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class VoicesDestroyCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid voiceId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> VoiceId { get; } = new(
            name: "voiceId")
        {
            Description = @"",
        };

        public VoicesDestroyCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "voices",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

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
            await _client.Voices.VoicesDestroyAsync(
                voiceId: voiceId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}