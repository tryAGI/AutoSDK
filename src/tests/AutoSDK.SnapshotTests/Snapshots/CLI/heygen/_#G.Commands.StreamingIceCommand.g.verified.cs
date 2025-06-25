//HintName: G.Commands.StreamingIceCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class StreamingIceCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.StreamingIceRequestCandidate? candidate,
            string? sessionId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<global::G.StreamingIceRequestCandidate?> Candidate { get; } = new(
            name: "candidate")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> SessionId { get; } = new(
            name: "sessionId")
        {
            Description = "",
        };
        public StreamingIceCommand(G.IApi client) : base(
            name: "streaming",
            description: @"streaming.ice")
        {
            _client = client;

            Options.Add(Candidate);
            Options.Add(SessionId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var candidate = parseResult.GetRequiredValue(Candidate);
            var sessionId = parseResult.GetRequiredValue(SessionId);

            Validate(
                parseResult: parseResult,
                candidate: candidate,
                sessionId: sessionId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.StreamingAPI.StreamingIceAsync(
                candidate: candidate,
                sessionId: sessionId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}