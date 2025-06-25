//HintName: G.Commands.ReposCreateDispatchEventCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReposCreateDispatchEventCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            string eventType,
            object? clientPayload,
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

        private global::System.CommandLine.Argument<string> EventType { get; } = new(
            name: "eventType")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<object?> ClientPayload { get; } = new(
            name: "clientPayload")
        {
            Description = "",
        };
        public ReposCreateDispatchEventCommand(G.IApi client) : base(
            name: "repos",
            description: @"You can use this endpoint to trigger a webhook event called `repository_dispatch` when you want activity that happens outside of GitHub to trigger a GitHub Actions workflow or GitHub App webhook. You must configure your GitHub Actions workflow or GitHub App to run when the `repository_dispatch` event occurs. For an example `repository_dispatch` webhook payload, see ""[RepositoryDispatchEvent](https://docs.github.com/webhooks/event-payloads/#repository_dispatch).""

The `client_payload` parameter is available for any extra information that your workflow might need. This parameter is a JSON payload that will be passed on when the webhook event is dispatched. For example, the `client_payload` can include a message that a user would like to send using a GitHub Actions workflow. Or the `client_payload` can be used as a test to debug your workflow.

This input example shows how you can use the `client_payload` as a test to debug your workflow.

OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(EventType);
            Options.Add(ClientPayload);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var eventType = parseResult.GetRequiredValue(EventType);
            var clientPayload = parseResult.GetRequiredValue(ClientPayload);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                eventType: eventType,
                clientPayload: clientPayload,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Repos.ReposCreateDispatchEventAsync(
                owner: owner,
                repo: repo,
                eventType: eventType,
                clientPayload: clientPayload,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}