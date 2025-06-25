//HintName: G.Commands.CreateProjectsAddCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateProjectsAddCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? xiApiKey,
            string name,
            string defaultTitleVoiceId,
            string defaultParagraphVoiceId,
            string defaultModelId,
            string? fromUrl,
            byte[]? fromDocument,
            string? fromDocumentname,
            string? fromContentJson,
            string? qualityPreset,
            string? title,
            string? author,
            string? description,
            global::System.Collections.Generic.IList<string>? genres,
            global::G.BodyAddProjectV1ProjectsAddPostTargetAudience? targetAudience,
            string? language,
            string? contentType,
            string? originalPublicationDate,
            bool? matureContent,
            string? isbnNumber,
            bool? acxVolumeNormalization,
            bool? volumeNormalization,
            global::System.Collections.Generic.IList<string>? pronunciationDictionaryLocators,
            string? callbackUrl,
            global::G.BodyAddProjectV1ProjectsAddPostFiction? fiction,
            global::G.BodyAddProjectV1ProjectsAddPostApplyTextNormalization? applyTextNormalization,
            bool? autoConvert,
            bool? autoAssignVoices,
            global::G.BodyAddProjectV1ProjectsAddPostSourceType? sourceType,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.AddProjectResponseModel response,
            global::System.Threading.CancellationToken cancellationToken);

        private new global::System.CommandLine.Argument<string> Name { get; } = new(
            name: "name")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> DefaultTitleVoiceId { get; } = new(
            name: "defaultTitleVoiceId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> DefaultParagraphVoiceId { get; } = new(
            name: "defaultParagraphVoiceId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> DefaultModelId { get; } = new(
            name: "defaultModelId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> FromUrl { get; } = new(
            name: "fromUrl")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<byte[]?> FromDocument { get; } = new(
            name: "fromDocument")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> FromDocumentname { get; } = new(
            name: "fromDocumentname")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> FromContentJson { get; } = new(
            name: "fromContentJson")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> QualityPreset { get; } = new(
            name: "qualityPreset")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Title { get; } = new(
            name: "title")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Author { get; } = new(
            name: "author")
        {
            Description = "",
        };

        private new global::System.CommandLine.Option<string?> Description { get; } = new(
            name: "description")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Genres { get; } = new(
            name: "genres")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.BodyAddProjectV1ProjectsAddPostTargetAudience?> TargetAudience { get; } = new(
            name: "targetAudience")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Language { get; } = new(
            name: "language")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> ContentType { get; } = new(
            name: "contentType")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> OriginalPublicationDate { get; } = new(
            name: "originalPublicationDate")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> MatureContent { get; } = new(
            name: "matureContent")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> IsbnNumber { get; } = new(
            name: "isbnNumber")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> AcxVolumeNormalization { get; } = new(
            name: "acxVolumeNormalization")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> VolumeNormalization { get; } = new(
            name: "volumeNormalization")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> PronunciationDictionaryLocators { get; } = new(
            name: "pronunciationDictionaryLocators")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> CallbackUrl { get; } = new(
            name: "callbackUrl")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.BodyAddProjectV1ProjectsAddPostFiction?> Fiction { get; } = new(
            name: "fiction")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.BodyAddProjectV1ProjectsAddPostApplyTextNormalization?> ApplyTextNormalization { get; } = new(
            name: "applyTextNormalization")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> AutoConvert { get; } = new(
            name: "autoConvert")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> AutoAssignVoices { get; } = new(
            name: "autoAssignVoices")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.BodyAddProjectV1ProjectsAddPostSourceType?> SourceType { get; } = new(
            name: "sourceType")
        {
            Description = "",
        };
        public CreateProjectsAddCommand(G.IApi client) : base(
            name: "create",
            description: @"Creates a new project, it can be either initialized as blank, from a document or from a URL.")
        {
            _client = client;

            Arguments.Add(Name);
            Arguments.Add(DefaultTitleVoiceId);
            Arguments.Add(DefaultParagraphVoiceId);
            Arguments.Add(DefaultModelId);
            Options.Add(XiApiKey);
            Options.Add(FromUrl);
            Options.Add(FromDocument);
            Options.Add(FromDocumentname);
            Options.Add(FromContentJson);
            Options.Add(QualityPreset);
            Options.Add(Title);
            Options.Add(Author);
            Options.Add(Description);
            Options.Add(Genres);
            Options.Add(TargetAudience);
            Options.Add(Language);
            Options.Add(ContentType);
            Options.Add(OriginalPublicationDate);
            Options.Add(MatureContent);
            Options.Add(IsbnNumber);
            Options.Add(AcxVolumeNormalization);
            Options.Add(VolumeNormalization);
            Options.Add(PronunciationDictionaryLocators);
            Options.Add(CallbackUrl);
            Options.Add(Fiction);
            Options.Add(ApplyTextNormalization);
            Options.Add(AutoConvert);
            Options.Add(AutoAssignVoices);
            Options.Add(SourceType);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var name = parseResult.GetRequiredValue(Name);
            var defaultTitleVoiceId = parseResult.GetRequiredValue(DefaultTitleVoiceId);
            var defaultParagraphVoiceId = parseResult.GetRequiredValue(DefaultParagraphVoiceId);
            var defaultModelId = parseResult.GetRequiredValue(DefaultModelId);
            var fromUrl = parseResult.GetRequiredValue(FromUrl);
            var fromDocument = parseResult.GetRequiredValue(FromDocument);
            var fromDocumentname = parseResult.GetRequiredValue(FromDocumentname);
            var fromContentJson = parseResult.GetRequiredValue(FromContentJson);
            var qualityPreset = parseResult.GetRequiredValue(QualityPreset);
            var title = parseResult.GetRequiredValue(Title);
            var author = parseResult.GetRequiredValue(Author);
            var description = parseResult.GetRequiredValue(Description);
            var genres = parseResult.GetRequiredValue(Genres);
            var targetAudience = parseResult.GetRequiredValue(TargetAudience);
            var language = parseResult.GetRequiredValue(Language);
            var contentType = parseResult.GetRequiredValue(ContentType);
            var originalPublicationDate = parseResult.GetRequiredValue(OriginalPublicationDate);
            var matureContent = parseResult.GetRequiredValue(MatureContent);
            var isbnNumber = parseResult.GetRequiredValue(IsbnNumber);
            var acxVolumeNormalization = parseResult.GetRequiredValue(AcxVolumeNormalization);
            var volumeNormalization = parseResult.GetRequiredValue(VolumeNormalization);
            var pronunciationDictionaryLocators = parseResult.GetRequiredValue(PronunciationDictionaryLocators);
            var callbackUrl = parseResult.GetRequiredValue(CallbackUrl);
            var fiction = parseResult.GetRequiredValue(Fiction);
            var applyTextNormalization = parseResult.GetRequiredValue(ApplyTextNormalization);
            var autoConvert = parseResult.GetRequiredValue(AutoConvert);
            var autoAssignVoices = parseResult.GetRequiredValue(AutoAssignVoices);
            var sourceType = parseResult.GetRequiredValue(SourceType);

            Validate(
                parseResult: parseResult,
                xiApiKey: xiApiKey,
                name: name,
                defaultTitleVoiceId: defaultTitleVoiceId,
                defaultParagraphVoiceId: defaultParagraphVoiceId,
                defaultModelId: defaultModelId,
                fromUrl: fromUrl,
                fromDocument: fromDocument,
                fromDocumentname: fromDocumentname,
                fromContentJson: fromContentJson,
                qualityPreset: qualityPreset,
                title: title,
                author: author,
                description: description,
                genres: genres,
                targetAudience: targetAudience,
                language: language,
                contentType: contentType,
                originalPublicationDate: originalPublicationDate,
                matureContent: matureContent,
                isbnNumber: isbnNumber,
                acxVolumeNormalization: acxVolumeNormalization,
                volumeNormalization: volumeNormalization,
                pronunciationDictionaryLocators: pronunciationDictionaryLocators,
                callbackUrl: callbackUrl,
                fiction: fiction,
                applyTextNormalization: applyTextNormalization,
                autoConvert: autoConvert,
                autoAssignVoices: autoAssignVoices,
                sourceType: sourceType,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Projects.CreateProjectsAddAsync(
                xiApiKey: xiApiKey,
                name: name,
                defaultTitleVoiceId: defaultTitleVoiceId,
                defaultParagraphVoiceId: defaultParagraphVoiceId,
                defaultModelId: defaultModelId,
                fromUrl: fromUrl,
                fromDocument: fromDocument,
                fromDocumentname: fromDocumentname,
                fromContentJson: fromContentJson,
                qualityPreset: qualityPreset,
                title: title,
                author: author,
                description: description,
                genres: genres,
                targetAudience: targetAudience,
                language: language,
                contentType: contentType,
                originalPublicationDate: originalPublicationDate,
                matureContent: matureContent,
                isbnNumber: isbnNumber,
                acxVolumeNormalization: acxVolumeNormalization,
                volumeNormalization: volumeNormalization,
                pronunciationDictionaryLocators: pronunciationDictionaryLocators,
                callbackUrl: callbackUrl,
                fiction: fiction,
                applyTextNormalization: applyTextNormalization,
                autoConvert: autoConvert,
                autoAssignVoices: autoAssignVoices,
                sourceType: sourceType,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}