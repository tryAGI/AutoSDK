//HintName: G.Commands.GetDubbingByDubbingIdCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetDubbingByDubbingIdCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string dubbingId,
            string? xiApiKey,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.DubbingMetadataResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> DubbingId { get; } = new(
            name: "dubbingId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };
        public GetDubbingByDubbingIdCommand(G.IApi client) : base(
            name: "get",
            description: @"Returns metadata about a dubbing project, including whether it's still in progress or not")
        {
            _client = client;

            Arguments.Add(DubbingId);
            Options.Add(XiApiKey);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var dubbingId = parseResult.GetRequiredValue(DubbingId);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);

            Validate(
                parseResult: parseResult,
                dubbingId: dubbingId,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Dubbing.GetDubbingByDubbingIdAsync(
                dubbingId: dubbingId,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}