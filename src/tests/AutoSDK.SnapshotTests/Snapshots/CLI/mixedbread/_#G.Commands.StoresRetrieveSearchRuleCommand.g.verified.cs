//HintName: G.Commands.StoresRetrieveSearchRuleCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class StoresRetrieveSearchRuleCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.AnyOf<string, global::System.Guid?> storeIdentifier,
            global::System.Guid ruleId,
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
            Description = @"The ID of the search rule",
        };



        public StoresRetrieveSearchRuleCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "retrieve",
            description: @"Get a search rule by ID.

Args:
    store_identifier: The ID or name of the store
    rule_id: The ID of the search rule to retrieve

Returns:
    SearchRuleResponse: The search rule details")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(StoreIdentifier);
            Arguments.Add(RuleId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var storeIdentifier = parseResult.GetRequiredValue(StoreIdentifier);
            var ruleId = parseResult.GetRequiredValue(RuleId);

            Validate(
                parseResult: parseResult,
                storeIdentifier: storeIdentifier,
                ruleId: ruleId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Stores.RetrieveSearchRuleAsync(
                storeIdentifier: storeIdentifier,
                ruleId: ruleId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}