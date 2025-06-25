//HintName: G.Commands.WebhooksUpdateCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class WebhooksUpdateCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid webhookId,
            string url,
            global::System.Collections.Generic.IList<string>? secrets,
            global::System.Collections.Generic.IList<global::G.EventsEnum> events,
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

        private global::System.CommandLine.Argument<string> Url { get; } = new(
            name: "url")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.EventsEnum>> Events { get; } = new(
            name: "events")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Secrets { get; } = new(
            name: "secrets")
        {
            Description = @"",
        };
        public WebhooksUpdateCommand(G.IApi client) : base(
            name: "webhooks",
            description: @"")
        {
            _client = client;

            Arguments.Add(WebhookId);
            Arguments.Add(Url);
            Arguments.Add(Events);
            Options.Add(Secrets);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var webhookId = parseResult.GetRequiredValue(WebhookId);
            var url = parseResult.GetRequiredValue(Url);
            var secrets = parseResult.GetRequiredValue(Secrets);
            var events = parseResult.GetRequiredValue(Events);

            Validate(
                parseResult: parseResult,
                webhookId: webhookId,
                url: url,
                secrets: secrets,
                events: events,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Webhooks.WebhooksUpdateAsync(
                webhookId: webhookId,
                url: url,
                secrets: secrets,
                events: events,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}