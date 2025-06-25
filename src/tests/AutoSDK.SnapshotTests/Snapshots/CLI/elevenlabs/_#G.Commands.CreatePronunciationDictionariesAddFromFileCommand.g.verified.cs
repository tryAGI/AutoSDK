//HintName: G.Commands.CreatePronunciationDictionariesAddFromFileCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreatePronunciationDictionariesAddFromFileCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? xiApiKey,
            string name,
            byte[]? file,
            string? filename,
            string? description,
            global::G.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccess? workspaceAccess,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.AddPronunciationDictionaryResponseModel response,
            global::System.Threading.CancellationToken cancellationToken);

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

        private global::System.CommandLine.Option<byte[]?> File { get; } = new(
            name: "file")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Filename { get; } = new(
            name: "filename")
        {
            Description = "",
        };

        private new global::System.CommandLine.Option<string?> Description { get; } = new(
            name: "description")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccess?> WorkspaceAccess { get; } = new(
            name: "workspaceAccess")
        {
            Description = "",
        };
        public CreatePronunciationDictionariesAddFromFileCommand(G.IApi client) : base(
            name: "create",
            description: @"Creates a new pronunciation dictionary from a lexicon .PLS file")
        {
            _client = client;

            Arguments.Add(Name);
            Options.Add(XiApiKey);
            Options.Add(File);
            Options.Add(Filename);
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
            var name = parseResult.GetRequiredValue(Name);
            var file = parseResult.GetRequiredValue(File);
            var filename = parseResult.GetRequiredValue(Filename);
            var description = parseResult.GetRequiredValue(Description);
            var workspaceAccess = parseResult.GetRequiredValue(WorkspaceAccess);

            Validate(
                parseResult: parseResult,
                xiApiKey: xiApiKey,
                name: name,
                file: file,
                filename: filename,
                description: description,
                workspaceAccess: workspaceAccess,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.PronunciationDictionary.CreatePronunciationDictionariesAddFromFileAsync(
                xiApiKey: xiApiKey,
                name: name,
                file: file,
                filename: filename,
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