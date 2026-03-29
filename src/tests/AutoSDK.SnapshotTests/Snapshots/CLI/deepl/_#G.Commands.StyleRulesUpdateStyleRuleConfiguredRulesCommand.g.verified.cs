//HintName: G.Commands.StyleRulesUpdateStyleRuleConfiguredRulesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class StyleRulesUpdateStyleRuleConfiguredRulesCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string styleId,
            global::G.ConfiguredRulesDatesAndTimes? datesAndTimes,
            global::G.ConfiguredRulesFormatting? formatting,
            global::G.ConfiguredRulesNumbers? numbers,
            global::G.ConfiguredRulesPunctuation? punctuation,
            global::G.ConfiguredRulesSpellingAndGrammar? spellingAndGrammar,
            global::G.ConfiguredRulesStyleAndTone? styleAndTone,
            global::G.ConfiguredRulesVocabulary? vocabulary,
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

        private global::System.CommandLine.Option<global::G.ConfiguredRulesDatesAndTimes?> DatesAndTimes { get; } = new(
            name: "datesAndTimes")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.ConfiguredRulesFormatting?> Formatting { get; } = new(
            name: "formatting")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.ConfiguredRulesNumbers?> Numbers { get; } = new(
            name: "numbers")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.ConfiguredRulesPunctuation?> Punctuation { get; } = new(
            name: "punctuation")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.ConfiguredRulesSpellingAndGrammar?> SpellingAndGrammar { get; } = new(
            name: "spellingAndGrammar")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.ConfiguredRulesStyleAndTone?> StyleAndTone { get; } = new(
            name: "styleAndTone")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.ConfiguredRulesVocabulary?> Vocabulary { get; } = new(
            name: "vocabulary")
        {
            Description = @"",
        };


        public StyleRulesUpdateStyleRuleConfiguredRulesCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "update",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(StyleId);
            Options.Add(DatesAndTimes);
            Options.Add(Formatting);
            Options.Add(Numbers);
            Options.Add(Punctuation);
            Options.Add(SpellingAndGrammar);
            Options.Add(StyleAndTone);
            Options.Add(Vocabulary);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var styleId = parseResult.GetRequiredValue(StyleId);
            var datesAndTimes = parseResult.GetRequiredValue(DatesAndTimes);
            var formatting = parseResult.GetRequiredValue(Formatting);
            var numbers = parseResult.GetRequiredValue(Numbers);
            var punctuation = parseResult.GetRequiredValue(Punctuation);
            var spellingAndGrammar = parseResult.GetRequiredValue(SpellingAndGrammar);
            var styleAndTone = parseResult.GetRequiredValue(StyleAndTone);
            var vocabulary = parseResult.GetRequiredValue(Vocabulary);

            Validate(
                parseResult: parseResult,
                styleId: styleId,
                datesAndTimes: datesAndTimes,
                formatting: formatting,
                numbers: numbers,
                punctuation: punctuation,
                spellingAndGrammar: spellingAndGrammar,
                styleAndTone: styleAndTone,
                vocabulary: vocabulary,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.StyleRules.UpdateStyleRuleConfiguredRulesAsync(
                styleId: styleId,
                datesAndTimes: datesAndTimes,
                formatting: formatting,
                numbers: numbers,
                punctuation: punctuation,
                spellingAndGrammar: spellingAndGrammar,
                styleAndTone: styleAndTone,
                vocabulary: vocabulary,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}