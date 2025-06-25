//HintName: G.Commands.DeleteTokenCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DeleteTokenCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string tokenId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            string response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> TokenId { get; } = new(
            name: "tokenId")
        {
            Description = @"",
        };

        public DeleteTokenCommand(G.IApi client) : base(
            name: "delete",
            description: @"Deletes an API token.")
        {
            _client = client;

            Arguments.Add(TokenId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var tokenId = parseResult.GetRequiredValue(TokenId);

            Validate(
                parseResult: parseResult,
                tokenId: tokenId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Namespace.DeleteTokenAsync(
                tokenId: tokenId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}