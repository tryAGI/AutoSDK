//HintName: G.Commands.InteractionsRemoveRestrictionsForOrgCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class InteractionsRemoveRestrictionsForOrgCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Org { get; } = new(
            name: "org")
        {
            Description = "",
        };

        public InteractionsRemoveRestrictionsForOrgCommand(G.IApi client) : base(
            name: "interactions",
            description: @"Removes all interaction restrictions from public repositories in the given organization. You must be an organization owner to remove restrictions.")
        {
            _client = client;

            Arguments.Add(Org);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);

            Validate(
                parseResult: parseResult,
                org: org,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Interactions.InteractionsRemoveRestrictionsForOrgAsync(
                org: org,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}