//HintName: G.Commands.DeprecatedVectorStoresDeprecatedDeleteSpecificSearchRuleCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DeprecatedVectorStoresDeprecatedDeleteSpecificSearchRuleCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.AnyOf<string, global::System.Guid?> vectorStoreIdentifier,
            global::System.Guid ruleId,
            global::G.Rule rule,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeleted response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.AnyOf<string, global::System.Guid?>> VectorStoreIdentifier { get; } = new(
            name: "vectorStoreIdentifier")
        {
            Description = @"The ID or name of the vector store",
        };

        private global::System.CommandLine.Argument<global::System.Guid> RuleId { get; } = new(
            name: "ruleId")
        {
            Description = @"The ID of the search rule",
        };

        private global::System.CommandLine.Argument<global::G.Rule> Rule { get; } = new(
            name: "rule")
        {
            Description = @"The specific rule to delete from the rules array",
        };



        public DeprecatedVectorStoresDeprecatedDeleteSpecificSearchRuleCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "deprecated",
            description: @"DEPRECATED: Use DELETE /stores/{store_identifier}/rules/{rule_id}/specific instead")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(VectorStoreIdentifier);
            Arguments.Add(RuleId);
            Arguments.Add(Rule);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var vectorStoreIdentifier = parseResult.GetRequiredValue(VectorStoreIdentifier);
            var ruleId = parseResult.GetRequiredValue(RuleId);
            var rule = parseResult.GetRequiredValue(Rule);

            Validate(
                parseResult: parseResult,
                vectorStoreIdentifier: vectorStoreIdentifier,
                ruleId: ruleId,
                rule: rule,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.DeprecatedVectorStores.DeprecatedDeleteSpecificSearchRuleAsync(
                vectorStoreIdentifier: vectorStoreIdentifier,
                ruleId: ruleId,
                rule: rule,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}