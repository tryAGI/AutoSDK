//HintName: G.Commands.StyleRulesGetStyleRuleListCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class StyleRulesGetStyleRuleListCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string styleId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.StyleRuleList response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> StyleId { get; } = new(
            name: "styleId")
        {
            Description = @"The unique ID of the style rule list",
        };



        public StyleRulesGetStyleRuleListCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(StyleId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var styleId = parseResult.GetRequiredValue(StyleId);

            Validate(
                parseResult: parseResult,
                styleId: styleId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.StyleRules.GetStyleRuleListAsync(
                styleId: styleId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}