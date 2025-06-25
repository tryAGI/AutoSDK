//HintName: G.Commands.UploadCertificateCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UploadCertificateCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? name,
            string content,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.Certificate response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Content { get; } = new(
            name: "content")
        {
            Description = "",
        };

        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = "",
        };
        public UploadCertificateCommand(G.IOpenAiClient client) : base(
            name: "upload",
            description: @"")
        {
            _client = client;

            Arguments.Add(Content);
            Options.Add(Name);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var name = parseResult.GetRequiredValue(Name);
            var content = parseResult.GetRequiredValue(Content);

            Validate(
                parseResult: parseResult,
                name: name,
                content: content,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Certificates.UploadCertificateAsync(
                name: name,
                content: content,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}