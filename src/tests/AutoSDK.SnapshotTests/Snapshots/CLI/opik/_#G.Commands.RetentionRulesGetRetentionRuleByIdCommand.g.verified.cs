//HintName: G.Commands.RetentionRulesGetRetentionRuleByIdCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class RetentionRulesGetRetentionRuleByIdCommand : global::System.CommandLine.Command
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

            global::G.RetentionRulePublic response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> RuleId { get; } = new(
            name: "ruleId")
        {
            Description = @"",
        };



        public RetentionRulesGetRetentionRuleByIdCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Get a specific retention rule by id")
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
            var response = await _client.RetentionRules.GetRetentionRuleByIdAsync(
                ruleId: ruleId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}