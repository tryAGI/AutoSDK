//HintName: G.Commands.CreateStudioProjectsByProjectIdContentCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateStudioProjectsByProjectIdContentCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string projectId,
            string? xiApiKey,
            string? fromUrl,
            byte[]? fromDocument,
            string? fromDocumentname,
            bool? autoConvert,
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

        private global::System.CommandLine.Option<bool?> AutoConvert { get; } = new(
            name: "autoConvert")
        {
            Description = "",
        };
        public CreateStudioProjectsByProjectIdContentCommand(G.IApi client) : base(
            name: "create",
            description: @"Updates Studio project content.")
        {
            _client = client;

            Arguments.Add(ProjectId);
            Options.Add(XiApiKey);
            Options.Add(FromUrl);
            Options.Add(FromDocument);
            Options.Add(FromDocumentname);
            Options.Add(AutoConvert);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var projectId = parseResult.GetRequiredValue(ProjectId);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var fromUrl = parseResult.GetRequiredValue(FromUrl);
            var fromDocument = parseResult.GetRequiredValue(FromDocument);
            var fromDocumentname = parseResult.GetRequiredValue(FromDocumentname);
            var autoConvert = parseResult.GetRequiredValue(AutoConvert);

            Validate(
                parseResult: parseResult,
                projectId: projectId,
                xiApiKey: xiApiKey,
                fromUrl: fromUrl,
                fromDocument: fromDocument,
                fromDocumentname: fromDocumentname,
                autoConvert: autoConvert,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Studio.CreateStudioProjectsByProjectIdContentAsync(
                projectId: projectId,
                xiApiKey: xiApiKey,
                fromUrl: fromUrl,
                fromDocument: fromDocument,
                fromDocumentname: fromDocumentname,
                autoConvert: autoConvert,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}