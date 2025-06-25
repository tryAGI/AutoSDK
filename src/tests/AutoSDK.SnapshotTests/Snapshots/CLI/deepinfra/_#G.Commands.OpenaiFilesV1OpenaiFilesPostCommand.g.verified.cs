//HintName: G.Commands.OpenaiFilesV1OpenaiFilesPostCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class OpenaiFilesV1OpenaiFilesPostCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? xiApiKey,
            string purpose,
            global::System.Collections.Generic.IList<byte[]> file,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            string response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Purpose { get; } = new(
            name: "purpose")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<byte[]>> File { get; } = new(
            name: "file")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = @"",
        };
        public OpenaiFilesV1OpenaiFilesPostCommand(G.IApi client) : base(
            name: "openai",
            description: @"")
        {
            _client = client;

            Arguments.Add(Purpose);
            Arguments.Add(File);
            Options.Add(XiApiKey);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var purpose = parseResult.GetRequiredValue(Purpose);
            var file = parseResult.GetRequiredValue(File);

            Validate(
                parseResult: parseResult,
                xiApiKey: xiApiKey,
                purpose: purpose,
                file: file,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.OpenaiFilesV1OpenaiFilesPostAsync(
                xiApiKey: xiApiKey,
                purpose: purpose,
                file: file,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}