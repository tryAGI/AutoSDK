//HintName: G.Commands.CancelResponseCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CancelResponseCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string responseId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.Response response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ResponseId { get; } = new(
            name: "responseId")
        {
            Description = "",
        };

        public CancelResponseCommand(G.IOpenAiClient client) : base(
            name: "cancel",
            description: @"")
        {
            _client = client;

            Arguments.Add(ResponseId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var responseId = parseResult.GetRequiredValue(ResponseId);

            Validate(
                parseResult: parseResult,
                responseId: responseId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Responses.CancelResponseAsync(
                responseId: responseId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}