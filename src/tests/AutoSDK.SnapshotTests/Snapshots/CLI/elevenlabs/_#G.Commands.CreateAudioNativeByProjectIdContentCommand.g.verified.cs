//HintName: G.Commands.CreateAudioNativeByProjectIdContentCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateAudioNativeByProjectIdContentCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string projectId,
            string? xiApiKey,
            byte[]? file,
            string? filename,
            bool? autoConvert,
            bool? autoPublish,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.AudioNativeEditContentResponseModel response,
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

        private global::System.CommandLine.Option<bool?> AutoConvert { get; } = new(
            name: "autoConvert")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> AutoPublish { get; } = new(
            name: "autoPublish")
        {
            Description = "",
        };
        public CreateAudioNativeByProjectIdContentCommand(G.IApi client) : base(
            name: "create",
            description: @"Updates content for the specific AudioNative Project.")
        {
            _client = client;

            Arguments.Add(ProjectId);
            Options.Add(XiApiKey);
            Options.Add(File);
            Options.Add(Filename);
            Options.Add(AutoConvert);
            Options.Add(AutoPublish);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var projectId = parseResult.GetRequiredValue(ProjectId);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var file = parseResult.GetRequiredValue(File);
            var filename = parseResult.GetRequiredValue(Filename);
            var autoConvert = parseResult.GetRequiredValue(AutoConvert);
            var autoPublish = parseResult.GetRequiredValue(AutoPublish);

            Validate(
                parseResult: parseResult,
                projectId: projectId,
                xiApiKey: xiApiKey,
                file: file,
                filename: filename,
                autoConvert: autoConvert,
                autoPublish: autoPublish,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.AudioNative.CreateAudioNativeByProjectIdContentAsync(
                projectId: projectId,
                xiApiKey: xiApiKey,
                file: file,
                filename: filename,
                autoConvert: autoConvert,
                autoPublish: autoPublish,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}