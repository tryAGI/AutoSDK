//HintName: G.Commands.AutomationRuleEvaluatorsUpdateAutomationRuleEvaluatorCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AutomationRuleEvaluatorsUpdateAutomationRuleEvaluatorCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid id,
            string name,
            float? samplingRate,
            bool? enabled,
            global::System.Guid? projectId,
            global::System.Collections.Generic.IList<global::System.Guid>? projectIds,
            global::G.AutomationRuleEvaluatorUpdateAction action,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> Id { get; } = new(
            name: "id")
        {
            Description = @"",
        };

        private new global::System.CommandLine.Argument<string> Name { get; } = new(
            name: "name")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<float?> SamplingRate { get; } = new(
            name: "samplingRate")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<bool?> Enabled { get; } = new(
            name: "enabled")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Guid?> ProjectId { get; } = new(
            name: "projectId")
        {
            Description = @"Primary project ID (legacy field, maintained for backwards compatibility)",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::System.Guid>?> ProjectIds { get; } = new(
            name: "projectIds")
        {
            Description = @"Multiple project IDs (new field for multi-project support)",
        };

        private new global::System.CommandLine.Option<global::G.AutomationRuleEvaluatorUpdateAction> Action { get; } = new(
            name: "action")
        {
            Description = @"",
        };


        public AutomationRuleEvaluatorsUpdateAutomationRuleEvaluatorCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "update",
            description: @"Update Automation Rule Evaluator by id")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Id);
            Arguments.Add(Name);
            Options.Add(SamplingRate);
            Options.Add(Enabled);
            Options.Add(ProjectId);
            Options.Add(ProjectIds);
            Options.Add(Action);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var id = parseResult.GetRequiredValue(Id);
            var name = parseResult.GetRequiredValue(Name);
            var samplingRate = parseResult.GetRequiredValue(SamplingRate);
            var enabled = parseResult.GetRequiredValue(Enabled);
            var projectId = parseResult.GetRequiredValue(ProjectId);
            var projectIds = parseResult.GetRequiredValue(ProjectIds);
            var action = parseResult.GetRequiredValue(Action);

            Validate(
                parseResult: parseResult,
                id: id,
                name: name,
                samplingRate: samplingRate,
                enabled: enabled,
                projectId: projectId,
                projectIds: projectIds,
                action: action,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.AutomationRuleEvaluators.UpdateAutomationRuleEvaluatorAsync(
                id: id,
                name: name,
                samplingRate: samplingRate,
                enabled: enabled,
                projectId: projectId,
                projectIds: projectIds,
                action: action,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}