//HintName: G.Commands.InteractionsSetRestrictionsForAuthenticatedUserCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class InteractionsSetRestrictionsForAuthenticatedUserCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.InteractionGroup limit,
            global::G.InteractionExpiry? expiry,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.InteractionLimitResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.InteractionGroup> Limit { get; } = new(
            name: "limit")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.InteractionExpiry?> Expiry { get; } = new(
            name: "expiry")
        {
            Description = "",
        };
        public InteractionsSetRestrictionsForAuthenticatedUserCommand(G.IApi client) : base(
            name: "interactions",
            description: @"Temporarily restricts which type of GitHub user can interact with your public repositories. Setting the interaction limit at the user level will overwrite any interaction limits that are set for individual repositories owned by the user.")
        {
            _client = client;

            Arguments.Add(Limit);
            Options.Add(Expiry);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var limit = parseResult.GetRequiredValue(Limit);
            var expiry = parseResult.GetRequiredValue(Expiry);

            Validate(
                parseResult: parseResult,
                limit: limit,
                expiry: expiry,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Interactions.InteractionsSetRestrictionsForAuthenticatedUserAsync(
                limit: limit,
                expiry: expiry,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}