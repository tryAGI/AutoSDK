//HintName: G.Commands.StreamingStopCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class StreamingStopCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? sessionId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<string?> SessionId { get; } = new(
            name: "sessionId")
        {
            Description = "",
        };
        public StreamingStopCommand(G.IApi client) : base(
            name: "streaming",
            description: @"streaming.stop")
        {
            _client = client;

            Options.Add(SessionId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var sessionId = parseResult.GetRequiredValue(SessionId);

            Validate(
                parseResult: parseResult,
                sessionId: sessionId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.StreamingAPI.StreamingStopAsync(
                sessionId: sessionId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}