//HintName: G.Commands.StyleRulesCreateStyleRuleListCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class StyleRulesCreateStyleRuleListCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string name,
            global::G.StyleRuleLanguage language,
            global::G.ConfiguredRules? configuredRules,
            global::System.Collections.Generic.IList<global::G.CustomInstructionRequest>? customInstructions,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.StyleRuleList response,
            global::System.Threading.CancellationToken cancellationToken);

        private new global::System.CommandLine.Argument<string> Name { get; } = new(
            name: "name")
        {
            Description = @"Name of the style rule list",
        };

        private global::System.CommandLine.Argument<global::G.StyleRuleLanguage> Language { get; } = new(
            name: "language")
        {
            Description = @"The language that the style rules are applied to.",
        };

        private global::System.CommandLine.Option<global::G.ConfiguredRules?> ConfiguredRules { get; } = new(
            name: "configuredRules")
        {
            Description = @"The enabled rules for the style rule list including what option was selected for each rule. This schema combines rules from all supported languages.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.CustomInstructionRequest>?> CustomInstructions { get; } = new(
            name: "customInstructions")
        {
            Description = @"List of custom instructions to enable for the style rule list",
        };


        public StyleRulesCreateStyleRuleListCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Name);
            Arguments.Add(Language);
            Options.Add(ConfiguredRules);
            Options.Add(CustomInstructions);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var name = parseResult.GetRequiredValue(Name);
            var language = parseResult.GetRequiredValue(Language);
            var configuredRules = parseResult.GetRequiredValue(ConfiguredRules);
            var customInstructions = parseResult.GetRequiredValue(CustomInstructions);

            Validate(
                parseResult: parseResult,
                name: name,
                language: language,
                configuredRules: configuredRules,
                customInstructions: customInstructions,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.StyleRules.CreateStyleRuleListAsync(
                name: name,
                language: language,
                configuredRules: configuredRules,
                customInstructions: customInstructions,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}