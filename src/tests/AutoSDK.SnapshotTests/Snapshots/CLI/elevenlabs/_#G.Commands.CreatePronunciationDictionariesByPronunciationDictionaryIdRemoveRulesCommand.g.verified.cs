//HintName: G.Commands.CreatePronunciationDictionariesByPronunciationDictionaryIdRemoveRulesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreatePronunciationDictionariesByPronunciationDictionaryIdRemoveRulesCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string pronunciationDictionaryId,
            string? xiApiKey,
            global::System.Collections.Generic.IList<string> ruleStrings,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.PronunciationDictionaryRulesResponseModel response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> PronunciationDictionaryId { get; } = new(
            name: "pronunciationDictionaryId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<string>> RuleStrings { get; } = new(
            name: "ruleStrings")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };
        public CreatePronunciationDictionariesByPronunciationDictionaryIdRemoveRulesCommand(G.IApi client) : base(
            name: "create",
            description: @"Remove rules from the pronunciation dictionary")
        {
            _client = client;

            Arguments.Add(PronunciationDictionaryId);
            Arguments.Add(RuleStrings);
            Options.Add(XiApiKey);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var pronunciationDictionaryId = parseResult.GetRequiredValue(PronunciationDictionaryId);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var ruleStrings = parseResult.GetRequiredValue(RuleStrings);

            Validate(
                parseResult: parseResult,
                pronunciationDictionaryId: pronunciationDictionaryId,
                xiApiKey: xiApiKey,
                ruleStrings: ruleStrings,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.PronunciationDictionary.CreatePronunciationDictionariesByPronunciationDictionaryIdRemoveRulesAsync(
                pronunciationDictionaryId: pronunciationDictionaryId,
                xiApiKey: xiApiKey,
                ruleStrings: ruleStrings,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}