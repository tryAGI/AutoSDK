//HintName: G.Commands.StyleRulesGetStyleRuleListsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class StyleRulesGetStyleRuleListsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int? page,
            int? pageSize,
            bool? detailed,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.GetStyleRuleListsResponse response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<int?> Page { get; } = new(
            name: "page")
        {
            Description = @"The index of the first page to return. Use with `page_size` to get the next page of rule lists",
        };

        private global::System.CommandLine.Option<int?> PageSize { get; } = new(
            name: "pageSize")
        {
            Description = @"The maximum number of style rule lists to return.",
        };

        private global::System.CommandLine.Option<bool?> Detailed { get; } = new(
            name: "detailed")
        {
            Description = @"Determines if the rule list's `configured_rules` and `custom_instructions` should be included in the response body.",
        };


        public StyleRulesGetStyleRuleListsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(Page);
            Options.Add(PageSize);
            Options.Add(Detailed);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var page = parseResult.GetRequiredValue(Page);
            var pageSize = parseResult.GetRequiredValue(PageSize);
            var detailed = parseResult.GetRequiredValue(Detailed);

            Validate(
                parseResult: parseResult,
                page: page,
                pageSize: pageSize,
                detailed: detailed,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.StyleRules.GetStyleRuleListsAsync(
                page: page,
                pageSize: pageSize,
                detailed: detailed,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}