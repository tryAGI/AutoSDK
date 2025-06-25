//HintName: G.Commands.PurgeLemurRequestDataCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PurgeLemurRequestDataCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string requestId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.PurgeLemurRequestDataResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> RequestId { get; } = new(
            name: "requestId")
        {
            Description = "",
        };

        public PurgeLemurRequestDataCommand(G.IApi client) : base(
            name: "purge",
            description: @"Delete the data for a previously submitted LeMUR request.
The LLM response data, as well as any context provided in the original request will be removed.
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
            var response = await _client.LeMUR.PurgeLemurRequestDataAsync(
                requestId: requestId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}