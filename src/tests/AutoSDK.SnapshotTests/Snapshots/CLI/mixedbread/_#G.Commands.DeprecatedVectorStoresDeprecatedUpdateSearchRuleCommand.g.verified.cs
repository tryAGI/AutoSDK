//HintName: G.Commands.DeprecatedVectorStoresDeprecatedUpdateSearchRuleCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DeprecatedVectorStoresDeprecatedUpdateSearchRuleCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.AnyOf<string, global::System.Guid?> vectorStoreIdentifier,
            global::System.Guid ruleId,
            string? query,
            global::System.Collections.Generic.IList<global::G.RulesVariant1Item>? rules,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.AnyOf<string, global::System.Guid?>> VectorStoreIdentifier { get; } = new(
            name: "vectorStoreIdentifier")
        {
            Description = @"The ID or name of the vector store",
        };

        private global::System.CommandLine.Argument<global::System.Guid> RuleId { get; } = new(
            name: "ruleId")
        {
            Description = @"The ID of the search rule to update",
        };

        private global::System.CommandLine.Option<string?> Query { get; } = new(
            name: "query")
        {
            Description = @"The query pattern to match",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.RulesVariant1Item>?> Rules { get; } = new(
            name: "rules")
        {
            Description = @"The rules to apply on query matches",
        };


        public DeprecatedVectorStoresDeprecatedUpdateSearchRuleCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "deprecated",
            description: @"DEPRECATED: Use PUT /stores/{store_identifier}/rules/{rule_id} instead")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(VectorStoreIdentifier);
            Arguments.Add(RuleId);
            Options.Add(Query);
            Options.Add(Rules);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var vectorStoreIdentifier = parseResult.GetRequiredValue(VectorStoreIdentifier);
            var ruleId = parseResult.GetRequiredValue(RuleId);
            var query = parseResult.GetRequiredValue(Query);
            var rules = parseResult.GetRequiredValue(Rules);

            Validate(
                parseResult: parseResult,
                vectorStoreIdentifier: vectorStoreIdentifier,
                ruleId: ruleId,
                query: query,
                rules: rules,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.DeprecatedVectorStores.DeprecatedUpdateSearchRuleAsync(
                vectorStoreIdentifier: vectorStoreIdentifier,
                ruleId: ruleId,
                query: query,
                rules: rules,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}