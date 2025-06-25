//HintName: G.Commands.GetLemurResponseCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetLemurResponseCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string requestId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.LemurResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> RequestId { get; } = new(
            name: "requestId")
        {
            Description = "",
        };

        public GetLemurResponseCommand(G.IApi client) : base(
            name: "get",
            description: @"Retrieve a LeMUR response that was previously generated.
")
        {
            _client = client;

            Arguments.Add(RequestId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var requestId = parseResult.GetRequiredValue(RequestId);

            Validate(
                parseResult: parseResult,
                requestId: requestId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.LeMUR.GetLemurResponseAsync(
                requestId: requestId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}