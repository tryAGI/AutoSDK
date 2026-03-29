//HintName: G.Commands.AutomationRuleEvaluatorsCreateAutomationRuleEvaluatorCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AutomationRuleEvaluatorsCreateAutomationRuleEvaluatorCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid? projectId,
            global::System.Collections.Generic.IList<global::System.Guid>? projectIds,
            string name,
            float? samplingRate,
            bool? enabled,
            global::G.AutomationRuleEvaluatorWriteAction action,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private new global::System.CommandLine.Argument<string> Name { get; } = new(
            name: "name")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Guid?> ProjectId { get; } = new(
            name: "projectId")
        {
            Description = @"Primary project ID (legacy field for backwards compatibility)",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::System.Guid>?> ProjectIds { get; } = new(
            name: "projectIds")
        {
            Description = @"Project IDs for write operations (used when creating/updating rules)",
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

        private new global::System.CommandLine.Option<global::G.AutomationRuleEvaluatorWriteAction> Action { get; } = new(
            name: "action")
        {
            Description = @"",
        };


        public AutomationRuleEvaluatorsCreateAutomationRuleEvaluatorCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Create automation rule evaluator")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Name);
            Options.Add(ProjectId);
            Options.Add(ProjectIds);
            Options.Add(SamplingRate);
            Options.Add(Enabled);
            Options.Add(Action);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var projectId = parseResult.GetRequiredValue(ProjectId);
            var projectIds = parseResult.GetRequiredValue(ProjectIds);
            var name = parseResult.GetRequiredValue(Name);
            var samplingRate = parseResult.GetRequiredValue(SamplingRate);
            var enabled = parseResult.GetRequiredValue(Enabled);
            var action = parseResult.GetRequiredValue(Action);

            Validate(
                parseResult: parseResult,
                projectId: projectId,
                projectIds: projectIds,
                name: name,
                samplingRate: samplingRate,
                enabled: enabled,
                action: action,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.AutomationRuleEvaluators.CreateAutomationRuleEvaluatorAsync(
                projectId: projectId,
                projectIds: projectIds,
                name: name,
                samplingRate: samplingRate,
                enabled: enabled,
                action: action,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}