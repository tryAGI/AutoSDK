//HintName: G.Commands.GetTokenCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetTokenCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string tokenId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetTokenResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> TokenId { get; } = new(
            name: "tokenId")
        {
            Description = "",
        };

        public GetTokenCommand(G.IApi client) : base(
            name: "get",
            description: @"Returns the details of an API token.")
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
            var response = await _client.Namespace.GetTokenAsync(
                tokenId: tokenId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}