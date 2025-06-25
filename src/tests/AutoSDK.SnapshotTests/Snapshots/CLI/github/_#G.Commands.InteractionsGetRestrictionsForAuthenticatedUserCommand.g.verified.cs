//HintName: G.Commands.InteractionsGetRestrictionsForAuthenticatedUserCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class InteractionsGetRestrictionsForAuthenticatedUserCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.AnyOf<global::G.InteractionLimitResponse, global::G.InteractionsGetRestrictionsForAuthenticatedUserResponse2> response,
            global::System.Threading.CancellationToken cancellationToken);


        public InteractionsGetRestrictionsForAuthenticatedUserCommand(G.IApi client) : base(
            name: "interactions",
            description: @"Shows which type of GitHub user can interact with your public repositories and when the restriction expires.")
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
            var response = await _client.Interactions.InteractionsGetRestrictionsForAuthenticatedUserAsync(
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}