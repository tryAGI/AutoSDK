//HintName: G.Commands.OrgsUpdateWebhookCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class OrgsUpdateWebhookCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            int hookId,
            global::G.OrgsUpdateWebhookRequestConfig? config,
            global::System.Collections.Generic.IList<string>? events,
            bool? active,
            string? name,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.OrgHook response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Org { get; } = new(
            name: "org")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<int> HookId { get; } = new(
            name: "hookId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.OrgsUpdateWebhookRequestConfig?> Config { get; } = new(
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

        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = "",
        };
        public OrgsUpdateWebhookCommand(G.IApi client) : base(
            name: "orgs",
            description: @"Updates a webhook configured in an organization. When you update a webhook,
the `secret` will be overwritten. If you previously had a `secret` set, you must
provide the same `secret` or set a new `secret` or the secret will be removed. If
you are only updating individual webhook `config` properties, use ""[Update a webhook
configuration for an organization](/rest/orgs/webhooks#update-a-webhook-configuration-for-an-organization)"".

You must be an organization owner to use this endpoint.

OAuth app tokens and personal access tokens (classic) need `admin:org_hook` scope. OAuth apps cannot list, view, or edit
webhooks that they did not create and users cannot list, view, or edit webhooks that were created by OAuth apps.")
        {
            _client = client;

            Arguments.Add(Org);
            Arguments.Add(HookId);
            Options.Add(Config);
            Options.Add(Events);
            Options.Add(Active);
            Options.Add(Name);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var hookId = parseResult.GetRequiredValue(HookId);
            var config = parseResult.GetRequiredValue(Config);
            var events = parseResult.GetRequiredValue(Events);
            var active = parseResult.GetRequiredValue(Active);
            var name = parseResult.GetRequiredValue(Name);

            Validate(
                parseResult: parseResult,
                org: org,
                hookId: hookId,
                config: config,
                events: events,
                active: active,
                name: name,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Orgs.OrgsUpdateWebhookAsync(
                org: org,
                hookId: hookId,
                config: config,
                events: events,
                active: active,
                name: name,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}