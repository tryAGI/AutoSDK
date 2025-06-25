//HintName: G.Commands.DeleteTokenCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DeleteTokenCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

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
            Description = @"Token ID",
        };

        public DeleteTokenCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "delete",
            description: @"Deletes an API token.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

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