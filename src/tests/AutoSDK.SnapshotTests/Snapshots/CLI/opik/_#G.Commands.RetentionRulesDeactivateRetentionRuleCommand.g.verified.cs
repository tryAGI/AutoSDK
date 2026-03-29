//HintName: G.Commands.RetentionRulesDeactivateRetentionRuleCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class RetentionRulesDeactivateRetentionRuleCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid ruleId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> RuleId { get; } = new(
            name: "ruleId")
        {
            Description = @"",
        };



        public RetentionRulesDeactivateRetentionRuleCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "deactivate",
            description: @"Soft-deactivate a retention rule (sets enabled=false). Rules are never hard-deleted for audit trail.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(RuleId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var ruleId = parseResult.GetRequiredValue(RuleId);

            Validate(
                parseResult: parseResult,
                ruleId: ruleId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.RetentionRules.DeactivateRetentionRuleAsync(
                ruleId: ruleId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}