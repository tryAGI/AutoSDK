//HintName: G.Commands.StreamingStartCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class StreamingStartCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.StreamingStartRequestSdp? sdp,
            string? sessionId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<global::G.StreamingStartRequestSdp?> Sdp { get; } = new(
            name: "sdp")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> SessionId { get; } = new(
            name: "sessionId")
        {
            Description = @"",
        };
        public StreamingStartCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "streaming",
            description: @"streaming.start")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(Sdp);
            Options.Add(SessionId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var sdp = parseResult.GetRequiredValue(Sdp);
            var sessionId = parseResult.GetRequiredValue(SessionId);

            Validate(
                parseResult: parseResult,
                sdp: sdp,
                sessionId: sessionId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.StreamingAPI.StreamingStartAsync(
                sdp: sdp,
                sessionId: sessionId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}