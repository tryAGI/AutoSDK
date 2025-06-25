//HintName: G.Commands.DeactivateProjectCertificatesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DeactivateProjectCertificatesCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string projectId,
            global::System.Collections.Generic.IList<string> certificateIds,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ListCertificatesResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ProjectId { get; } = new(
            name: "projectId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<string>> CertificateIds { get; } = new(
            name: "certificateIds")
        {
            Description = "",
        };

        public DeactivateProjectCertificatesCommand(G.IOpenAiClient client) : base(
            name: "deactivate",
            description: @"")
        {
            _client = client;

            Arguments.Add(ProjectId);
            Arguments.Add(CertificateIds);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var projectId = parseResult.GetRequiredValue(ProjectId);
            var certificateIds = parseResult.GetRequiredValue(CertificateIds);

            Validate(
                parseResult: parseResult,
                projectId: projectId,
                certificateIds: certificateIds,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Certificates.DeactivateProjectCertificatesAsync(
                projectId: projectId,
                certificateIds: certificateIds,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}