//HintName: G.Commands.ActionsUpdateOrgVariableCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ActionsUpdateOrgVariableCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            string name,
            string? requestName,
            string? value,
            global::G.ActionsUpdateOrgVariableRequestVisibility? visibility,
            global::System.Collections.Generic.IList<int>? selectedRepositoryIds,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
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

        private global::System.CommandLine.Option<string?> RequestName { get; } = new(
            name: "requestName")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Value { get; } = new(
            name: "value")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ActionsUpdateOrgVariableRequestVisibility?> Visibility { get; } = new(
            name: "visibility")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<int>?> SelectedRepositoryIds { get; } = new(
            name: "selectedRepositoryIds")
        {
            Description = "",
        };
        public ActionsUpdateOrgVariableCommand(G.IApi client) : base(
            name: "actions",
            description: @"Updates an organization variable that you can reference in a GitHub Actions workflow.

Authenticated users must have collaborator access to a repository to create, update, or read variables.

OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint. If the repository is private, the `repo` scope is also required.")
        {
            _client = client;

            Arguments.Add(Org);
            Arguments.Add(Name);
            Options.Add(RequestName);
            Options.Add(Value);
            Options.Add(Visibility);
            Options.Add(SelectedRepositoryIds);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var name = parseResult.GetRequiredValue(Name);
            var requestName = parseResult.GetRequiredValue(RequestName);
            var value = parseResult.GetRequiredValue(Value);
            var visibility = parseResult.GetRequiredValue(Visibility);
            var selectedRepositoryIds = parseResult.GetRequiredValue(SelectedRepositoryIds);

            Validate(
                parseResult: parseResult,
                org: org,
                name: name,
                requestName: requestName,
                value: value,
                visibility: visibility,
                selectedRepositoryIds: selectedRepositoryIds,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Actions.ActionsUpdateOrgVariableAsync(
                org: org,
                name: name,
                requestName: requestName,
                value: value,
                visibility: visibility,
                selectedRepositoryIds: selectedRepositoryIds,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}