//HintName: G.Commands.ReposCreateWebhookCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReposCreateWebhookCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            string? name,
            global::G.ReposCreateWebhookRequestConfig? config,
            global::System.Collections.Generic.IList<string>? events,
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

        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ReposCreateWebhookRequestConfig?> Config { get; } = new(
            name: "config")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Events { get; } = new(
            name: "events")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> Active { get; } = new(
            name: "active")
        {
            Description = "",
        };
        public ReposCreateWebhookCommand(G.IApi client) : base(
            name: "repos",
            description: @"Repositories can have multiple webhooks installed. Each webhook should have a unique `config`. Multiple webhooks can
share the same `config` as long as those webhooks do not have any `events` that overlap.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Options.Add(Name);
            Options.Add(Config);
            Options.Add(Events);
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
            var name = parseResult.GetRequiredValue(Name);
            var config = parseResult.GetRequiredValue(Config);
            var events = parseResult.GetRequiredValue(Events);
            var active = parseResult.GetRequiredValue(Active);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                name: name,
                config: config,
                events: events,
                active: active,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Repos.ReposCreateWebhookAsync(
                owner: owner,
                repo: repo,
                name: name,
                config: config,
                events: events,
                active: active,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}