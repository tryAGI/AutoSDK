//HintName: G.Commands.GetCertificateCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetCertificateCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string certificateId,
            global::System.Collections.Generic.IList<global::G.GetCertificateIncludeItem>? include,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.Certificate response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> CertificateId { get; } = new(
            name: "certificateId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.GetCertificateIncludeItem>?> Include { get; } = new(
            name: "include")
        {
            Description = "",
        };
        public GetCertificateCommand(G.IOpenAiClient client) : base(
            name: "get",
            description: @"")
        {
            _client = client;

            Arguments.Add(CertificateId);
            Options.Add(Include);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var certificateId = parseResult.GetRequiredValue(CertificateId);
            var include = parseResult.GetRequiredValue(Include);

            Validate(
                parseResult: parseResult,
                certificateId: certificateId,
                include: include,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Certificates.GetCertificateAsync(
                certificateId: certificateId,
                include: include,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}