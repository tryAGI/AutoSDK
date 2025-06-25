//HintName: G.Commands.CreatePronunciationDictionariesAddFromRulesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreatePronunciationDictionariesAddFromRulesCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? xiApiKey,
            global::System.Collections.Generic.IList<global::G.AnyOf<global::G.PronunciationDictionaryAliasRuleRequestModel, global::G.PronunciationDictionaryPhonemeRuleRequestModel>> rules,
            string name,
            string? description,
            global::G.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPostWorkspaceAccess? workspaceAccess,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.AddPronunciationDictionaryResponseModel response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.AnyOf<global::G.PronunciationDictionaryAliasRuleRequestModel, global::G.PronunciationDictionaryPhonemeRuleRequestModel>>> Rules { get; } = new(
            name: "rules")
        {
            Description = "",
        };

        private new global::System.CommandLine.Argument<string> Name { get; } = new(
            name: "name")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };

        private new global::System.CommandLine.Option<string?> Description { get; } = new(
            name: "description")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPostWorkspaceAccess?> WorkspaceAccess { get; } = new(
            name: "workspaceAccess")
        {
            Description = "",
        };
        public CreatePronunciationDictionariesAddFromRulesCommand(G.IApi client) : base(
            name: "create",
            description: @"Creates a new pronunciation dictionary from provided rules.")
        {
            _client = client;

            Arguments.Add(Rules);
            Arguments.Add(Name);
            Options.Add(XiApiKey);
            Options.Add(Description);
            Options.Add(WorkspaceAccess);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var rules = parseResult.GetRequiredValue(Rules);
            var name = parseResult.GetRequiredValue(Name);
            var description = parseResult.GetRequiredValue(Description);
            var workspaceAccess = parseResult.GetRequiredValue(WorkspaceAccess);

            Validate(
                parseResult: parseResult,
                xiApiKey: xiApiKey,
                rules: rules,
                name: name,
                description: description,
                workspaceAccess: workspaceAccess,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.PronunciationDictionary.CreatePronunciationDictionariesAddFromRulesAsync(
                xiApiKey: xiApiKey,
                rules: rules,
                name: name,
                description: description,
                workspaceAccess: workspaceAccess,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}