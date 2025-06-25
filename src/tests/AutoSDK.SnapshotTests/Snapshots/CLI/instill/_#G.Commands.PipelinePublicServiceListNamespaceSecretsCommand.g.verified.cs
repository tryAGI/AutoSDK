//HintName: G.Commands.PipelinePublicServiceListNamespaceSecretsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PipelinePublicServiceListNamespaceSecretsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string namespaceId,
            int? pageSize,
            string? pageToken,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ListNamespaceSecretsResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> NamespaceId { get; } = new(
            name: "namespaceId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> PageSize { get; } = new(
            name: "pageSize")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> PageToken { get; } = new(
            name: "pageToken")
        {
            Description = "",
        };
        public PipelinePublicServiceListNamespaceSecretsCommand(G.IApi client) : base(
            name: "pipeline",
            description: @"Returns a paginated list of secrets that belong to the specified
namespace.")
        {
            _client = client;

            Arguments.Add(NamespaceId);
            Options.Add(PageSize);
            Options.Add(PageToken);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var namespaceId = parseResult.GetRequiredValue(NamespaceId);
            var pageSize = parseResult.GetRequiredValue(PageSize);
            var pageToken = parseResult.GetRequiredValue(PageToken);

            Validate(
                parseResult: parseResult,
                namespaceId: namespaceId,
                pageSize: pageSize,
                pageToken: pageToken,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.VDP.PipelinePublicServiceListNamespaceSecretsAsync(
                namespaceId: namespaceId,
                pageSize: pageSize,
                pageToken: pageToken,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}