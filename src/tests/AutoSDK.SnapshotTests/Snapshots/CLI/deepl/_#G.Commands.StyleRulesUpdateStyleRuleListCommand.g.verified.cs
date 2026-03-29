//HintName: G.Commands.StyleRulesUpdateStyleRuleListCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class StyleRulesUpdateStyleRuleListCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string styleId,
            string? name,
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

        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = @"Name of the style rule list",
        };


        public StyleRulesUpdateStyleRuleListCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "update",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(StyleId);
            Options.Add(Name);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var styleId = parseResult.GetRequiredValue(StyleId);
            var name = parseResult.GetRequiredValue(Name);

            Validate(
                parseResult: parseResult,
                styleId: styleId,
                name: name,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.StyleRules.UpdateStyleRuleListAsync(
                styleId: styleId,
                name: name,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}