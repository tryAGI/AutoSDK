//HintName: G.Commands.InteractionsRemoveRestrictionsForAuthenticatedUserCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class InteractionsRemoveRestrictionsForAuthenticatedUserCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);


        public InteractionsRemoveRestrictionsForAuthenticatedUserCommand(G.IApi client) : base(
            name: "interactions",
            description: @"Removes any interaction restrictions from your public repositories.")
        {
            _client = client;


            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            Validate(
                parseResult: parseResult,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Interactions.InteractionsRemoveRestrictionsForAuthenticatedUserAsync(
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}