//HintName: G.Commands.CreatePronunciationDictionariesByPronunciationDictionaryIdAddRulesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreatePronunciationDictionariesByPronunciationDictionaryIdAddRulesCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string pronunciationDictionaryId,
            string? xiApiKey,
            global::System.Collections.Generic.IList<global::G.AnyOf<global::G.PronunciationDictionaryAliasRuleRequestModel, global::G.PronunciationDictionaryPhonemeRuleRequestModel>> rules,
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

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.AnyOf<global::G.PronunciationDictionaryAliasRuleRequestModel, global::G.PronunciationDictionaryPhonemeRuleRequestModel>>> Rules { get; } = new(
            name: "rules")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };
        public CreatePronunciationDictionariesByPronunciationDictionaryIdAddRulesCommand(G.IApi client) : base(
            name: "create",
            description: @"Add rules to the pronunciation dictionary")
        {
            _client = client;

            Arguments.Add(PronunciationDictionaryId);
            Arguments.Add(Rules);
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
            var rules = parseResult.GetRequiredValue(Rules);

            Validate(
                parseResult: parseResult,
                pronunciationDictionaryId: pronunciationDictionaryId,
                xiApiKey: xiApiKey,
                rules: rules,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.PronunciationDictionary.CreatePronunciationDictionariesByPronunciationDictionaryIdAddRulesAsync(
                pronunciationDictionaryId: pronunciationDictionaryId,
                xiApiKey: xiApiKey,
                rules: rules,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}