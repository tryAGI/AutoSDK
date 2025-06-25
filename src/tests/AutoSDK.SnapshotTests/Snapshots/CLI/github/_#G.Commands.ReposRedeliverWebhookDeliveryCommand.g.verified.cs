//HintName: G.Commands.ReposRedeliverWebhookDeliveryCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReposRedeliverWebhookDeliveryCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            int hookId,
            int deliveryId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            string response,
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

        private global::System.CommandLine.Argument<int> DeliveryId { get; } = new(
            name: "deliveryId")
        {
            Description = "",
        };

        public ReposRedeliverWebhookDeliveryCommand(G.IApi client) : base(
            name: "repos",
            description: @"Redeliver a webhook delivery for a webhook configured in a repository.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(HookId);
            Arguments.Add(DeliveryId);

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
            var deliveryId = parseResult.GetRequiredValue(DeliveryId);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                hookId: hookId,
                deliveryId: deliveryId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Repos.ReposRedeliverWebhookDeliveryAsync(
                owner: owner,
                repo: repo,
                hookId: hookId,
                deliveryId: deliveryId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}