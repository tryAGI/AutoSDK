//HintName: G.Commands.AppsListWebhookDeliveriesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AppsListWebhookDeliveriesCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int? perPage,
            string? cursor,
            bool? redelivery,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.HookDeliveryItem> response,
            global::System.Threading.CancellationToken cancellationToken);


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
        public AppsListWebhookDeliveriesCommand(G.IApi client) : base(
            name: "apps",
            description: @"Returns a list of webhook deliveries for the webhook configured for a GitHub App.

You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.")
        {
            _client = client;

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
            var perPage = parseResult.GetRequiredValue(PerPage);
            var cursor = parseResult.GetRequiredValue(Cursor);
            var redelivery = parseResult.GetRequiredValue(Redelivery);

            Validate(
                parseResult: parseResult,
                perPage: perPage,
                cursor: cursor,
                redelivery: redelivery,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Apps.AppsListWebhookDeliveriesAsync(
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