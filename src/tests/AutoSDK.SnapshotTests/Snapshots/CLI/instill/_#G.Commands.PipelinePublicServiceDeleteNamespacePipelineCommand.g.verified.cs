//HintName: G.Commands.PipelinePublicServiceDeleteNamespacePipelineCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PipelinePublicServiceDeleteNamespacePipelineCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string namespaceId,
            string pipelineId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            string response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> NamespaceId { get; } = new(
            name: "namespaceId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> PipelineId { get; } = new(
            name: "pipelineId")
        {
            Description = "",
        };

        public PipelinePublicServiceDeleteNamespacePipelineCommand(G.IApi client) : base(
            name: "pipeline",
            description: @"Deletes a pipeline, accesing it by its resource name, which is defined by
the parent namespace and the ID of the pipeline. The authenticated namespace must be
the parent of the pipeline in order to delete it.")
        {
            _client = client;

            Arguments.Add(NamespaceId);
            Arguments.Add(PipelineId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var namespaceId = parseResult.GetRequiredValue(NamespaceId);
            var pipelineId = parseResult.GetRequiredValue(PipelineId);

            Validate(
                parseResult: parseResult,
                namespaceId: namespaceId,
                pipelineId: pipelineId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.VDP.PipelinePublicServiceDeleteNamespacePipelineAsync(
                namespaceId: namespaceId,
                pipelineId: pipelineId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}