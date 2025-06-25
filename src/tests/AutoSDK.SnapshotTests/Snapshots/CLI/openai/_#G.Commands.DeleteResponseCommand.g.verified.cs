//HintName: G.Commands.DeleteResponseCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DeleteResponseCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string responseId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ResponseId { get; } = new(
            name: "responseId")
        {
            Description = "",
        };

        public DeleteResponseCommand(G.IOpenAiClient client) : base(
            name: "delete",
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
            await _client.Responses.DeleteResponseAsync(
                responseId: responseId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}