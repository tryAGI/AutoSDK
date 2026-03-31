//HintName: G.Commands.StoresUpdateSearchRuleCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class StoresUpdateSearchRuleCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.AnyOf<string, global::System.Guid?> storeIdentifier,
            global::System.Guid ruleId,
            string? query,
            global::System.Collections.Generic.IList<global::G.RulesVariant1Item2>? rules,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.AnyOf<string, global::System.Guid?>> StoreIdentifier { get; } = new(
            name: "storeIdentifier")
        {
            Description = @"The ID or name of the store",
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

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.RulesVariant1Item2>?> Rules { get; } = new(
            name: "rules")
        {
            Description = @"The rules to apply on query matches",
        };


        public StoresUpdateSearchRuleCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "update",
            description: @"Update a search rule by ID.

Args:
    store_identifier: The ID or name of the store
    rule_id: The ID of the search rule to update
    rule_update: SearchRuleUpdateParams object containing the fields to update

Returns:
    SearchRuleResponse: The updated search rule details")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(StoreIdentifier);
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
            var storeIdentifier = parseResult.GetRequiredValue(StoreIdentifier);
            var ruleId = parseResult.GetRequiredValue(RuleId);
            var query = parseResult.GetRequiredValue(Query);
            var rules = parseResult.GetRequiredValue(Rules);

            Validate(
                parseResult: parseResult,
                storeIdentifier: storeIdentifier,
                ruleId: ruleId,
                query: query,
                rules: rules,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Stores.UpdateSearchRuleAsync(
                storeIdentifier: storeIdentifier,
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