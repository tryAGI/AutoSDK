//HintName: G.Commands.RetentionRulesFindRetentionRulesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class RetentionRulesFindRetentionRulesCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int? page,
            int? size,
            bool? includeInactive,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.RetentionRulePagePublic response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<int?> Page { get; } = new(
            name: "page")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> Size { get; } = new(
            name: "size")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<bool?> IncludeInactive { get; } = new(
            name: "includeInactive")
        {
            Description = @"",
        };


        public RetentionRulesFindRetentionRulesCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "find",
            description: @"List retention rules for the caller's workspace. Defaults to active only.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(Page);
            Options.Add(Size);
            Options.Add(IncludeInactive);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var page = parseResult.GetRequiredValue(Page);
            var size = parseResult.GetRequiredValue(Size);
            var includeInactive = parseResult.GetRequiredValue(IncludeInactive);

            Validate(
                parseResult: parseResult,
                page: page,
                size: size,
                includeInactive: includeInactive,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.RetentionRules.FindRetentionRulesAsync(
                page: page,
                size: size,
                includeInactive: includeInactive,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}