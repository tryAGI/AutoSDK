//HintName: G.Commands.AppsGetWebhookDeliveryCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AppsGetWebhookDeliveryCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int deliveryId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.HookDelivery response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<int> DeliveryId { get; } = new(
            name: "deliveryId")
        {
            Description = "",
        };

        public AppsGetWebhookDeliveryCommand(G.IApi client) : base(
            name: "apps",
            description: @"Returns a delivery for the webhook configured for a GitHub App.

You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.")
        {
            _client = client;

            Arguments.Add(DeliveryId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var deliveryId = parseResult.GetRequiredValue(DeliveryId);

            Validate(
                parseResult: parseResult,
                deliveryId: deliveryId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Apps.AppsGetWebhookDeliveryAsync(
                deliveryId: deliveryId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}