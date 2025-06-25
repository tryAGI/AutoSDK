//HintName: G.Commands.ReposUpdateWebhookCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReposUpdateWebhookCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            int hookId,
            global::G.WebhookConfig? config,
            global::System.Collections.Generic.IList<string>? events,
            global::System.Collections.Generic.IList<string>? addEvents,
            global::System.Collections.Generic.IList<string>? removeEvents,
            bool? active,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.Hook response,
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

        private global::System.CommandLine.Option<global::G.WebhookConfig?> Config { get; } = new(
            name: "config")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Events { get; } = new(
            name: "events")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> AddEvents { get; } = new(
            name: "addEvents")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> RemoveEvents { get; } = new(
            name: "removeEvents")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> Active { get; } = new(
            name: "active")
        {
            Description = "",
        };
        public ReposUpdateWebhookCommand(G.IApi client) : base(
            name: "repos",
            description: @"Updates a webhook configured in a repository. If you previously had a `secret` set, you must provide the same `secret` or set a new `secret` or the secret will be removed. If you are only updating individual webhook `config` properties, use ""[Update a webhook configuration for a repository](/rest/webhooks/repo-config#update-a-webhook-configuration-for-a-repository).""")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(HookId);
            Options.Add(Config);
            Options.Add(Events);
            Options.Add(AddEvents);
            Options.Add(RemoveEvents);
            Options.Add(Active);

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
            var config = parseResult.GetRequiredValue(Config);
            var events = parseResult.GetRequiredValue(Events);
            var addEvents = parseResult.GetRequiredValue(AddEvents);
            var removeEvents = parseResult.GetRequiredValue(RemoveEvents);
            var active = parseResult.GetRequiredValue(Active);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                hookId: hookId,
                config: config,
                events: events,
                addEvents: addEvents,
                removeEvents: removeEvents,
                active: active,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Repos.ReposUpdateWebhookAsync(
                owner: owner,
                repo: repo,
                hookId: hookId,
                config: config,
                events: events,
                addEvents: addEvents,
                removeEvents: removeEvents,
                active: active,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}