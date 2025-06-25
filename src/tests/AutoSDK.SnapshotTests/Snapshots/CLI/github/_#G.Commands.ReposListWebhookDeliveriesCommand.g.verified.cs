//HintName: G.Commands.ReposListWebhookDeliveriesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReposListWebhookDeliveriesCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            int hookId,
            int? perPage,
            string? cursor,
            bool? redelivery,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.HookDeliveryItem> response,
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
        public ReposListWebhookDeliveriesCommand(G.IApi client) : base(
            name: "repos",
            description: @"Returns a list of webhook deliveries for a webhook configured in a repository.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
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
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var hookId = parseResult.GetRequiredValue(HookId);
            var perPage = parseResult.GetRequiredValue(PerPage);
            var cursor = parseResult.GetRequiredValue(Cursor);
            var redelivery = parseResult.GetRequiredValue(Redelivery);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                hookId: hookId,
                perPage: perPage,
                cursor: cursor,
                redelivery: redelivery,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Repos.ReposListWebhookDeliveriesAsync(
                owner: owner,
                repo: repo,
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