//HintName: G.Commands.OrgsListWebhookDeliveriesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class OrgsListWebhookDeliveriesCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            int hookId,
            int? perPage,
            string? cursor,
            bool? redelivery,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.HookDeliveryItem> response,
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

        private global::System.CommandLine.Option<int?> PerPage { get; } = new(
            name: "perPage")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Cursor { get; } = new(
            name: "cursor")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> Redelivery { get; } = new(
            name: "redelivery")
        {
            Description = "",
        };
        public OrgsListWebhookDeliveriesCommand(G.IApi client) : base(
            name: "orgs",
            description: @"Returns a list of webhook deliveries for a webhook configured in an organization.

You must be an organization owner to use this endpoint.

OAuth app tokens and personal access tokens (classic) need `admin:org_hook` scope. OAuth apps cannot list, view, or edit
webhooks that they did not create and users cannot list, view, or edit webhooks that were created by OAuth apps.")
        {
            _client = client;

            Arguments.Add(Org);
            Arguments.Add(HookId);
            Options.Add(PerPage);
            Options.Add(Cursor);
            Options.Add(Redelivery);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var hookId = parseResult.GetRequiredValue(HookId);
            var perPage = parseResult.GetRequiredValue(PerPage);
            var cursor = parseResult.GetRequiredValue(Cursor);
            var redelivery = parseResult.GetRequiredValue(Redelivery);

            Validate(
                parseResult: parseResult,
                org: org,
                hookId: hookId,
                perPage: perPage,
                cursor: cursor,
                redelivery: redelivery,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Orgs.OrgsListWebhookDeliveriesAsync(
                org: org,
                hookId: hookId,
                perPage: perPage,
                cursor: cursor,
                redelivery: redelivery,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}