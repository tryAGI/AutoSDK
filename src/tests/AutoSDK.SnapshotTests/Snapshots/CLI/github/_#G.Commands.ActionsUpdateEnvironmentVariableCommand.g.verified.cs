//HintName: G.Commands.ActionsUpdateEnvironmentVariableCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ActionsUpdateEnvironmentVariableCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            string name,
            string environmentName,
            string? requestName,
            string? value,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
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

        private new global::System.CommandLine.Argument<string> Name { get; } = new(
            name: "name")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> EnvironmentName { get; } = new(
            name: "environmentName")
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
        public ActionsUpdateEnvironmentVariableCommand(G.IApi client) : base(
            name: "actions",
            description: @"Updates an environment variable that you can reference in a GitHub Actions workflow.

Authenticated users must have collaborator access to a repository to create, update, or read variables.

OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(Name);
            Arguments.Add(EnvironmentName);
            Options.Add(RequestName);
            Options.Add(Value);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var name = parseResult.GetRequiredValue(Name);
            var environmentName = parseResult.GetRequiredValue(EnvironmentName);
            var requestName = parseResult.GetRequiredValue(RequestName);
            var value = parseResult.GetRequiredValue(Value);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                name: name,
                environmentName: environmentName,
                requestName: requestName,
                value: value,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Actions.ActionsUpdateEnvironmentVariableAsync(
                owner: owner,
                repo: repo,
                name: name,
                environmentName: environmentName,
                requestName: requestName,
                value: value,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}