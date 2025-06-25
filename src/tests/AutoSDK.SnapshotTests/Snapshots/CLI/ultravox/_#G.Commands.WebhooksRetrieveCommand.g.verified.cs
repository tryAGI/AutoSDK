//HintName: G.Commands.WebhooksRetrieveCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class WebhooksRetrieveCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid webhookId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.Webhook response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> WebhookId { get; } = new(
            name: "webhookId")
        {
            Description = @"",
        };

        public WebhooksRetrieveCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "webhooks",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

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
            var response = await _client.Webhooks.WebhooksRetrieveAsync(
                webhookId: webhookId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}