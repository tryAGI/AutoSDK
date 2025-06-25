//HintName: G.Commands.CreateForcedAlignmentCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateForcedAlignmentCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? xiApiKey,
            byte[] file,
            string filename,
            string text,
            bool? enabledSpooledFile,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ForcedAlignmentResponseModel response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<byte[]> File { get; } = new(
            name: "file")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Filename { get; } = new(
            name: "filename")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Text { get; } = new(
            name: "text")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> EnabledSpooledFile { get; } = new(
            name: "enabledSpooledFile")
        {
            Description = "",
        };
        public CreateForcedAlignmentCommand(G.IApi client) : base(
            name: "create",
            description: @"Force align an audio file to text. Use this endpoint to get the timing information for each character and word in an audio file based on a provided text transcript.")
        {
            _client = client;

            Arguments.Add(File);
            Arguments.Add(Filename);
            Arguments.Add(Text);
            Options.Add(XiApiKey);
            Options.Add(EnabledSpooledFile);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var file = parseResult.GetRequiredValue(File);
            var filename = parseResult.GetRequiredValue(Filename);
            var text = parseResult.GetRequiredValue(Text);
            var enabledSpooledFile = parseResult.GetRequiredValue(EnabledSpooledFile);

            Validate(
                parseResult: parseResult,
                xiApiKey: xiApiKey,
                file: file,
                filename: filename,
                text: text,
                enabledSpooledFile: enabledSpooledFile,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ForcedAlignment.CreateForcedAlignmentAsync(
                xiApiKey: xiApiKey,
                file: file,
                filename: filename,
                text: text,
                enabledSpooledFile: enabledSpooledFile,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}