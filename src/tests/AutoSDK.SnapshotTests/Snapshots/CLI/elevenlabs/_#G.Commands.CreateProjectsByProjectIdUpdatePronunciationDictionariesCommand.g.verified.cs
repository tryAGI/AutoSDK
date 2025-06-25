//HintName: G.Commands.CreateProjectsByProjectIdUpdatePronunciationDictionariesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateProjectsByProjectIdUpdatePronunciationDictionariesCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string projectId,
            string? xiApiKey,
            global::System.Collections.Generic.IList<global::G.PronunciationDictionaryVersionLocatorDBModel> pronunciationDictionaryLocators,
            bool? invalidateAffectedText,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            string response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ProjectId { get; } = new(
            name: "projectId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.PronunciationDictionaryVersionLocatorDBModel>> PronunciationDictionaryLocators { get; } = new(
            name: "pronunciationDictionaryLocators")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> InvalidateAffectedText { get; } = new(
            name: "invalidateAffectedText")
        {
            Description = "",
        };
        public CreateProjectsByProjectIdUpdatePronunciationDictionariesCommand(G.IApi client) : base(
            name: "create",
            description: @"Updates the set of pronunciation dictionaries acting on a project. This will automatically mark text within this project as requiring reconverting where the new dictionary would apply or the old one no longer does.")
        {
            _client = client;

            Arguments.Add(ProjectId);
            Arguments.Add(PronunciationDictionaryLocators);
            Options.Add(XiApiKey);
            Options.Add(InvalidateAffectedText);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var projectId = parseResult.GetRequiredValue(ProjectId);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var pronunciationDictionaryLocators = parseResult.GetRequiredValue(PronunciationDictionaryLocators);
            var invalidateAffectedText = parseResult.GetRequiredValue(InvalidateAffectedText);

            Validate(
                parseResult: parseResult,
                projectId: projectId,
                xiApiKey: xiApiKey,
                pronunciationDictionaryLocators: pronunciationDictionaryLocators,
                invalidateAffectedText: invalidateAffectedText,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Projects.CreateProjectsByProjectIdUpdatePronunciationDictionariesAsync(
                projectId: projectId,
                xiApiKey: xiApiKey,
                pronunciationDictionaryLocators: pronunciationDictionaryLocators,
                invalidateAffectedText: invalidateAffectedText,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}