//HintName: G.Commands.AlertsTestWebhookCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AlertsTestWebhookCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid? id,
            string? name,
            bool? enabled,
            global::G.AlertWriteAlertType? alertType,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            global::G.WebhookWrite webhook,
            global::System.Collections.Generic.IList<global::G.AlertTriggerWrite>? triggers,
            global::System.Guid? projectId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.WebhookTestResult response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.WebhookWrite> Webhook { get; } = new(
            name: "webhook")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Guid?> Id { get; } = new(
            name: "id")
        {
            Description = @"",
        };

        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<bool?> Enabled { get; } = new(
            name: "enabled")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.AlertWriteAlertType?> AlertType { get; } = new(
            name: "alertType")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.Dictionary<string, string>?> Metadata { get; } = new(
            name: "metadata")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.AlertTriggerWrite>?> Triggers { get; } = new(
            name: "triggers")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Guid?> ProjectId { get; } = new(
            name: "projectId")
        {
            Description = @"Optional project scope for this alert. When set, the alert is scoped to the specified project. Do NOT also provide a 'scope:project' trigger config — the system will create it automatically from this field. Sending both project_id and a scope:project trigger config will result in an error.",
        };


        public AlertsTestWebhookCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "test",
            description: @"Test alert webhook")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Webhook);
            Options.Add(Id);
            Options.Add(Name);
            Options.Add(Enabled);
            Options.Add(AlertType);
            Options.Add(Metadata);
            Options.Add(Triggers);
            Options.Add(ProjectId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var id = parseResult.GetRequiredValue(Id);
            var name = parseResult.GetRequiredValue(Name);
            var enabled = parseResult.GetRequiredValue(Enabled);
            var alertType = parseResult.GetRequiredValue(AlertType);
            var metadata = parseResult.GetRequiredValue(Metadata);
            var webhook = parseResult.GetRequiredValue(Webhook);
            var triggers = parseResult.GetRequiredValue(Triggers);
            var projectId = parseResult.GetRequiredValue(ProjectId);

            Validate(
                parseResult: parseResult,
                id: id,
                name: name,
                enabled: enabled,
                alertType: alertType,
                metadata: metadata,
                webhook: webhook,
                triggers: triggers,
                projectId: projectId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Alerts.TestWebhookAsync(
                id: id,
                name: name,
                enabled: enabled,
                alertType: alertType,
                metadata: metadata,
                webhook: webhook,
                triggers: triggers,
                projectId: projectId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}