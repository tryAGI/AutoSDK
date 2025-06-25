//HintName: G.Commands.ReposUpdateWebhookConfigForRepoCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReposUpdateWebhookConfigForRepoCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            int hookId,
            string? url,
            string? contentType,
            string? secret,
            global::G.WebhookConfigInsecureSsl? insecureSsl,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.WebhookConfig response,
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

        private global::System.CommandLine.Argument<int> HookId { get; } = new(
            name: "hookId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Url { get; } = new(
            name: "url")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> ContentType { get; } = new(
            name: "contentType")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Secret { get; } = new(
            name: "secret")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.WebhookConfigInsecureSsl?> InsecureSsl { get; } = new(
            name: "insecureSsl")
        {
            Description = "",
        };
        public ReposUpdateWebhookConfigForRepoCommand(G.IApi client) : base(
            name: "repos",
            description: @"Updates the webhook configuration for a repository. To update more information about the webhook, including the `active` state and `events`, use ""[Update a repository webhook](/rest/webhooks/repos#update-a-repository-webhook).""

OAuth app tokens and personal access tokens (classic) need the `write:repo_hook` or `repo` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(HookId);
            Options.Add(Url);
            Options.Add(ContentType);
            Options.Add(Secret);
            Options.Add(InsecureSsl);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var hookId = parseResult.GetRequiredValue(HookId);
            var url = parseResult.GetRequiredValue(Url);
            var contentType = parseResult.GetRequiredValue(ContentType);
            var secret = parseResult.GetRequiredValue(Secret);
            var insecureSsl = parseResult.GetRequiredValue(InsecureSsl);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                hookId: hookId,
                url: url,
                contentType: contentType,
                secret: secret,
                insecureSsl: insecureSsl,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Repos.ReposUpdateWebhookConfigForRepoAsync(
                owner: owner,
                repo: repo,
                hookId: hookId,
                url: url,
                contentType: contentType,
                secret: secret,
                insecureSsl: insecureSsl,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}