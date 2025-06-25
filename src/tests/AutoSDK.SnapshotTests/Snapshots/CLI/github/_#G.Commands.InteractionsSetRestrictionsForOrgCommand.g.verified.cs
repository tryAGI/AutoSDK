//HintName: G.Commands.InteractionsSetRestrictionsForOrgCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class InteractionsSetRestrictionsForOrgCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            global::G.InteractionGroup limit,
            global::G.InteractionExpiry? expiry,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.InteractionLimitResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Org { get; } = new(
            name: "org")
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
        public InteractionsSetRestrictionsForOrgCommand(G.IApi client) : base(
            name: "interactions",
            description: @"Temporarily restricts interactions to a certain type of GitHub user in any public repository in the given organization. You must be an organization owner to set these restrictions. Setting the interaction limit at the organization level will overwrite any interaction limits that are set for individual repositories owned by the organization.")
        {
            _client = client;

            Arguments.Add(Org);
            Arguments.Add(Limit);
            Options.Add(Expiry);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var limit = parseResult.GetRequiredValue(Limit);
            var expiry = parseResult.GetRequiredValue(Expiry);

            Validate(
                parseResult: parseResult,
                org: org,
                limit: limit,
                expiry: expiry,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Interactions.InteractionsSetRestrictionsForOrgAsync(
                org: org,
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