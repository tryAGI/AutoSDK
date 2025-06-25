//HintName: G.Commands.WebhooksDestroyCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class WebhooksDestroyCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid webhookId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> WebhookId { get; } = new(
            name: "webhookId")
        {
            Description = @"",
        };

        public WebhooksDestroyCommand(G.IApi client) : base(
            name: "webhooks",
            description: @"")
        {
            _client = client;

            Arguments.Add(WebhookId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var webhookId = parseResult.GetRequiredValue(WebhookId);

            Validate(
                parseResult: parseResult,
                webhookId: webhookId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Webhooks.WebhooksDestroyAsync(
                webhookId: webhookId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}