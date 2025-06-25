//HintName: G.Commands.ActionsUpdateSelfHostedRunnerGroupForOrgCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ActionsUpdateSelfHostedRunnerGroupForOrgCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            int runnerGroupId,
            string name,
            global::G.ActionsUpdateSelfHostedRunnerGroupForOrgRequestVisibility? visibility,
            bool? allowsPublicRepositories,
            bool? restrictedToWorkflows,
            global::System.Collections.Generic.IList<string>? selectedWorkflows,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.RunnerGroupsOrg response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Org { get; } = new(
            name: "org")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<int> RunnerGroupId { get; } = new(
            name: "runnerGroupId")
        {
            Description = "",
        };

        private new global::System.CommandLine.Argument<string> Name { get; } = new(
            name: "name")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ActionsUpdateSelfHostedRunnerGroupForOrgRequestVisibility?> Visibility { get; } = new(
            name: "visibility")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> AllowsPublicRepositories { get; } = new(
            name: "allowsPublicRepositories")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> RestrictedToWorkflows { get; } = new(
            name: "restrictedToWorkflows")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> SelectedWorkflows { get; } = new(
            name: "selectedWorkflows")
        {
            Description = "",
        };
        public ActionsUpdateSelfHostedRunnerGroupForOrgCommand(G.IApi client) : base(
            name: "actions",
            description: @"Updates the `name` and `visibility` of a self-hosted runner group in an organization.

OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Org);
            Arguments.Add(RunnerGroupId);
            Arguments.Add(Name);
            Options.Add(Visibility);
            Options.Add(AllowsPublicRepositories);
            Options.Add(RestrictedToWorkflows);
            Options.Add(SelectedWorkflows);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var runnerGroupId = parseResult.GetRequiredValue(RunnerGroupId);
            var name = parseResult.GetRequiredValue(Name);
            var visibility = parseResult.GetRequiredValue(Visibility);
            var allowsPublicRepositories = parseResult.GetRequiredValue(AllowsPublicRepositories);
            var restrictedToWorkflows = parseResult.GetRequiredValue(RestrictedToWorkflows);
            var selectedWorkflows = parseResult.GetRequiredValue(SelectedWorkflows);

            Validate(
                parseResult: parseResult,
                org: org,
                runnerGroupId: runnerGroupId,
                name: name,
                visibility: visibility,
                allowsPublicRepositories: allowsPublicRepositories,
                restrictedToWorkflows: restrictedToWorkflows,
                selectedWorkflows: selectedWorkflows,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Actions.ActionsUpdateSelfHostedRunnerGroupForOrgAsync(
                org: org,
                runnerGroupId: runnerGroupId,
                name: name,
                visibility: visibility,
                allowsPublicRepositories: allowsPublicRepositories,
                restrictedToWorkflows: restrictedToWorkflows,
                selectedWorkflows: selectedWorkflows,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}