//HintName: G.Commands.StoresCreateSearchRuleCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class StoresCreateSearchRuleCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.AnyOf<string, global::System.Guid?> storeIdentifier,
            string query,
            global::System.Collections.Generic.IList<global::G.RulesItem3> rules,
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

        private global::System.CommandLine.Argument<string> Query { get; } = new(
            name: "query")
        {
            Description = @"The query pattern to match",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.RulesItem3>> Rules { get; } = new(
            name: "rules")
        {
            Description = @"The rules to apply on query matches",
        };



        public StoresCreateSearchRuleCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Create a new search rule for a store.

Args:
    store_identifier: The ID or name of the store
    rule_create: Search rule creation parameters

Returns:
    SearchRuleResponse: The created search rule details")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(StoreIdentifier);
            Arguments.Add(Query);
            Arguments.Add(Rules);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var storeIdentifier = parseResult.GetRequiredValue(StoreIdentifier);
            var query = parseResult.GetRequiredValue(Query);
            var rules = parseResult.GetRequiredValue(Rules);

            Validate(
                parseResult: parseResult,
                storeIdentifier: storeIdentifier,
                query: query,
                rules: rules,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Stores.CreateSearchRuleAsync(
                storeIdentifier: storeIdentifier,
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