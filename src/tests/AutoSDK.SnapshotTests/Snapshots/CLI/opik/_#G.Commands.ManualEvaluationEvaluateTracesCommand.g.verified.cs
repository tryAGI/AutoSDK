//HintName: G.Commands.ManualEvaluationEvaluateTracesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ManualEvaluationEvaluateTracesCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid projectId,
            global::System.Collections.Generic.IList<global::System.Guid> entityIds,
            global::System.Collections.Generic.IList<global::System.Guid> ruleIds,
            global::G.ManualEvaluationRequestEntityType entityType,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.ManualEvaluationResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> ProjectId { get; } = new(
            name: "projectId")
        {
            Description = @"Project ID",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::System.Guid>> EntityIds { get; } = new(
            name: "entityIds")
        {
            Description = @"List of entity IDs (trace IDs or thread IDs) to evaluate",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::System.Guid>> RuleIds { get; } = new(
            name: "ruleIds")
        {
            Description = @"List of automation rule IDs to apply",
        };

        private global::System.CommandLine.Argument<global::G.ManualEvaluationRequestEntityType> EntityType { get; } = new(
            name: "entityType")
        {
            Description = @"Type of entity to evaluate (trace or thread)",
        };



        public ManualEvaluationEvaluateTracesCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "evaluate",
            description: @"Manually trigger evaluation rules on selected traces. Bypasses sampling and enqueues all specified traces for evaluation.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(ProjectId);
            Arguments.Add(EntityIds);
            Arguments.Add(RuleIds);
            Arguments.Add(EntityType);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var projectId = parseResult.GetRequiredValue(ProjectId);
            var entityIds = parseResult.GetRequiredValue(EntityIds);
            var ruleIds = parseResult.GetRequiredValue(RuleIds);
            var entityType = parseResult.GetRequiredValue(EntityType);

            Validate(
                parseResult: parseResult,
                projectId: projectId,
                entityIds: entityIds,
                ruleIds: ruleIds,
                entityType: entityType,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ManualEvaluation.EvaluateTracesAsync(
                projectId: projectId,
                entityIds: entityIds,
                ruleIds: ruleIds,
                entityType: entityType,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}