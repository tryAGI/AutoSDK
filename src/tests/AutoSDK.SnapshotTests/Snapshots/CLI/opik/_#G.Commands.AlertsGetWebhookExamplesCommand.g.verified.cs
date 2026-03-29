//HintName: G.Commands.AlertsGetWebhookExamplesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AlertsGetWebhookExamplesCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetWebhookExamplesAlertType? alertType,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.WebhookExamples response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<global::G.GetWebhookExamplesAlertType?> AlertType { get; } = new(
            name: "alertType")
        {
            Description = @"",
        };


        public AlertsGetWebhookExamplesCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Get webhook payload examples for all alert event types, optionally filtered by alert type")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(AlertType);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var alertType = parseResult.GetRequiredValue(AlertType);

            Validate(
                parseResult: parseResult,
                alertType: alertType,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Alerts.GetWebhookExamplesAsync(
                alertType: alertType,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}