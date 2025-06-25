//HintName: G.Commands.OrgsUpdateWebhookConfigForOrgCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class OrgsUpdateWebhookConfigForOrgCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
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
        public OrgsUpdateWebhookConfigForOrgCommand(G.IApi client) : base(
            name: "orgs",
            description: @"Updates the webhook configuration for an organization. To update more information about the webhook, including the `active` state and `events`, use ""[Update an organization webhook ](/rest/orgs/webhooks#update-an-organization-webhook).""

You must be an organization owner to use this endpoint.

OAuth app tokens and personal access tokens (classic) need `admin:org_hook` scope. OAuth apps cannot list, view, or edit
webhooks that they did not create and users cannot list, view, or edit webhooks that were created by OAuth apps.")
        {
            _client = client;

            Arguments.Add(Org);
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
            var org = parseResult.GetRequiredValue(Org);
            var hookId = parseResult.GetRequiredValue(HookId);
            var url = parseResult.GetRequiredValue(Url);
            var contentType = parseResult.GetRequiredValue(ContentType);
            var secret = parseResult.GetRequiredValue(Secret);
            var insecureSsl = parseResult.GetRequiredValue(InsecureSsl);

            Validate(
                parseResult: parseResult,
                org: org,
                hookId: hookId,
                url: url,
                contentType: contentType,
                secret: secret,
                insecureSsl: insecureSsl,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Orgs.OrgsUpdateWebhookConfigForOrgAsync(
                org: org,
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