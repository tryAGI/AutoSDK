//HintName: G.Commands.InteractionsSetRestrictionsForRepoCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class InteractionsSetRestrictionsForRepoCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            global::G.InteractionGroup limit,
            global::G.InteractionExpiry? expiry,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.InteractionLimitResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Owner { get; } = new(
            name: "owner")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Repo { get; } = new(
            name: "repo")
        {
            Description = "",
        };

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
        public InteractionsSetRestrictionsForRepoCommand(G.IApi client) : base(
            name: "interactions",
            description: @"Temporarily restricts interactions to a certain type of GitHub user within the given repository. You must have owner or admin access to set these restrictions. If an interaction limit is set for the user or organization that owns this repository, you will receive a `409 Conflict` response and will not be able to use this endpoint to change the interaction limit for a single repository.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(Limit);
            Options.Add(Expiry);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var limit = parseResult.GetRequiredValue(Limit);
            var expiry = parseResult.GetRequiredValue(Expiry);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                limit: limit,
                expiry: expiry,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Interactions.InteractionsSetRestrictionsForRepoAsync(
                owner: owner,
                repo: repo,
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