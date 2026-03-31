//HintName: G.Commands.StoresDeleteSpecificSearchRuleCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class StoresDeleteSpecificSearchRuleCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.AnyOf<string, global::System.Guid?> storeIdentifier,
            global::System.Guid ruleId,
            global::G.Rule2 rule,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleted response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.AnyOf<string, global::System.Guid?>> StoreIdentifier { get; } = new(
            name: "storeIdentifier")
        {
            Description = @"The ID or name of the store",
        };

        private global::System.CommandLine.Argument<global::System.Guid> RuleId { get; } = new(
            name: "ruleId")
        {
            Description = @"The ID of the search rule",
        };

        private global::System.CommandLine.Argument<global::G.Rule2> Rule { get; } = new(
            name: "rule")
        {
            Description = @"The specific rule to delete from the rules array",
        };



        public StoresDeleteSpecificSearchRuleCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "delete",
            description: @"Delete a specific rule from within a search rule's rules array.

Args:
    store_identifier: The ID or name of the store
    rule_id: The ID of the search rule containing the rule to delete
    rule_delete: The specific rule to delete from the rules array

Returns:
    SearchRuleSpecificDeleted: Details about the deletion operation")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(StoreIdentifier);
            Arguments.Add(RuleId);
            Arguments.Add(Rule);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var storeIdentifier = parseResult.GetRequiredValue(StoreIdentifier);
            var ruleId = parseResult.GetRequiredValue(RuleId);
            var rule = parseResult.GetRequiredValue(Rule);

            Validate(
                parseResult: parseResult,
                storeIdentifier: storeIdentifier,
                ruleId: ruleId,
                rule: rule,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Stores.DeleteSpecificSearchRuleAsync(
                storeIdentifier: storeIdentifier,
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