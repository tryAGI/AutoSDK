//HintName: G.Commands.OrgsGetWebhookCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class OrgsGetWebhookCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            int hookId,
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

        public OrgsGetWebhookCommand(G.IApi client) : base(
            name: "orgs",
            description: @"Returns a webhook configured in an organization. To get only the webhook
`config` properties, see ""[Get a webhook configuration for an organization](/rest/orgs/webhooks#get-a-webhook-configuration-for-an-organization).

You must be an organization owner to use this endpoint.

OAuth app tokens and personal access tokens (classic) need `admin:org_hook` scope. OAuth apps cannot list, view, or edit
webhooks that they did not create and users cannot list, view, or edit webhooks that were created by OAuth apps.")
        {
            _client = client;

            Arguments.Add(Org);
            Arguments.Add(HookId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var hookId = parseResult.GetRequiredValue(HookId);

            Validate(
                parseResult: parseResult,
                org: org,
                hookId: hookId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Orgs.OrgsGetWebhookAsync(
                org: org,
                hookId: hookId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}