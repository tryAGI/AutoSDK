//HintName: G.Commands.ActionsCreateSelfHostedRunnerGroupForOrgCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ActionsCreateSelfHostedRunnerGroupForOrgCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            string name,
            global::G.ActionsCreateSelfHostedRunnerGroupForOrgRequestVisibility? visibility,
            global::System.Collections.Generic.IList<int>? selectedRepositoryIds,
            global::System.Collections.Generic.IList<int>? runners,
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

        private new global::System.CommandLine.Argument<string> Name { get; } = new(
            name: "name")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ActionsCreateSelfHostedRunnerGroupForOrgRequestVisibility?> Visibility { get; } = new(
            name: "visibility")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<int>?> SelectedRepositoryIds { get; } = new(
            name: "selectedRepositoryIds")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<int>?> Runners { get; } = new(
            name: "runners")
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
        public ActionsCreateSelfHostedRunnerGroupForOrgCommand(G.IApi client) : base(
            name: "actions",
            description: @"Creates a new self-hosted runner group for an organization.

OAuth tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Org);
            Arguments.Add(Name);
            Options.Add(Visibility);
            Options.Add(SelectedRepositoryIds);
            Options.Add(Runners);
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
            var name = parseResult.GetRequiredValue(Name);
            var visibility = parseResult.GetRequiredValue(Visibility);
            var selectedRepositoryIds = parseResult.GetRequiredValue(SelectedRepositoryIds);
            var runners = parseResult.GetRequiredValue(Runners);
            var allowsPublicRepositories = parseResult.GetRequiredValue(AllowsPublicRepositories);
            var restrictedToWorkflows = parseResult.GetRequiredValue(RestrictedToWorkflows);
            var selectedWorkflows = parseResult.GetRequiredValue(SelectedWorkflows);

            Validate(
                parseResult: parseResult,
                org: org,
                name: name,
                visibility: visibility,
                selectedRepositoryIds: selectedRepositoryIds,
                runners: runners,
                allowsPublicRepositories: allowsPublicRepositories,
                restrictedToWorkflows: restrictedToWorkflows,
                selectedWorkflows: selectedWorkflows,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Actions.ActionsCreateSelfHostedRunnerGroupForOrgAsync(
                org: org,
                name: name,
                visibility: visibility,
                selectedRepositoryIds: selectedRepositoryIds,
                runners: runners,
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