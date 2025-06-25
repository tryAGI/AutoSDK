//HintName: G.Commands.CreateStudioProjectsByProjectIdCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateStudioProjectsByProjectIdCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string projectId,
            string? xiApiKey,
            string name,
            string defaultTitleVoiceId,
            string defaultParagraphVoiceId,
            string? title,
            string? author,
            string? isbnNumber,
            bool? volumeNormalization,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.EditProjectResponseModel response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ProjectId { get; } = new(
            name: "projectId")
        {
            Description = "",
        };

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

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
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

        private global::System.CommandLine.Option<string?> IsbnNumber { get; } = new(
            name: "isbnNumber")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> VolumeNormalization { get; } = new(
            name: "volumeNormalization")
        {
            Description = "",
        };
        public CreateStudioProjectsByProjectIdCommand(G.IApi client) : base(
            name: "create",
            description: @"Updates the specified Studio project by setting the values of the parameters passed.")
        {
            _client = client;

            Arguments.Add(ProjectId);
            Arguments.Add(Name);
            Arguments.Add(DefaultTitleVoiceId);
            Arguments.Add(DefaultParagraphVoiceId);
            Options.Add(XiApiKey);
            Options.Add(Title);
            Options.Add(Author);
            Options.Add(IsbnNumber);
            Options.Add(VolumeNormalization);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var projectId = parseResult.GetRequiredValue(ProjectId);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var name = parseResult.GetRequiredValue(Name);
            var defaultTitleVoiceId = parseResult.GetRequiredValue(DefaultTitleVoiceId);
            var defaultParagraphVoiceId = parseResult.GetRequiredValue(DefaultParagraphVoiceId);
            var title = parseResult.GetRequiredValue(Title);
            var author = parseResult.GetRequiredValue(Author);
            var isbnNumber = parseResult.GetRequiredValue(IsbnNumber);
            var volumeNormalization = parseResult.GetRequiredValue(VolumeNormalization);

            Validate(
                parseResult: parseResult,
                projectId: projectId,
                xiApiKey: xiApiKey,
                name: name,
                defaultTitleVoiceId: defaultTitleVoiceId,
                defaultParagraphVoiceId: defaultParagraphVoiceId,
                title: title,
                author: author,
                isbnNumber: isbnNumber,
                volumeNormalization: volumeNormalization,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Studio.CreateStudioProjectsByProjectIdAsync(
                projectId: projectId,
                xiApiKey: xiApiKey,
                name: name,
                defaultTitleVoiceId: defaultTitleVoiceId,
                defaultParagraphVoiceId: defaultParagraphVoiceId,
                title: title,
                author: author,
                isbnNumber: isbnNumber,
                volumeNormalization: volumeNormalization,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}