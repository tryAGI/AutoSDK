//HintName: G.Commands.ActionsRemoveCustomLabelFromSelfHostedRunnerForOrgCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ActionsRemoveCustomLabelFromSelfHostedRunnerForOrgCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            int runnerId,
            string name,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ActionsRemoveCustomLabelFromSelfHostedRunnerForOrgResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Org { get; } = new(
            name: "org")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<int> RunnerId { get; } = new(
            name: "runnerId")
        {
            Description = "",
        };

        private new global::System.CommandLine.Argument<string> Name { get; } = new(
            name: "name")
        {
            Description = "",
        };

        public ActionsRemoveCustomLabelFromSelfHostedRunnerForOrgCommand(G.IApi client) : base(
            name: "actions",
            description: @"Remove a custom label from a self-hosted runner configured
in an organization. Returns the remaining labels from the runner.

This endpoint returns a `404 Not Found` status if the custom label is not
present on the runner.

Authenticated users must have admin access to the organization to use this endpoint.

OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint. If the repository is private, the `repo` scope is also required.")
        {
            _client = client;

            Arguments.Add(Org);
            Arguments.Add(RunnerId);
            Arguments.Add(Name);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var runnerId = parseResult.GetRequiredValue(RunnerId);
            var name = parseResult.GetRequiredValue(Name);

            Validate(
                parseResult: parseResult,
                org: org,
                runnerId: runnerId,
                name: name,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Actions.ActionsRemoveCustomLabelFromSelfHostedRunnerForOrgAsync(
                org: org,
                runnerId: runnerId,
                name: name,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}