//HintName: G.Commands.PipelinePublicServiceRenameNamespacePipelineCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PipelinePublicServiceRenameNamespacePipelineCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string namespaceId,
            string pipelineId,
            string newPipelineId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.RenameNamespacePipelineResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> NamespaceId { get; } = new(
            name: "namespaceId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> PipelineId { get; } = new(
            name: "pipelineId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> NewPipelineId { get; } = new(
            name: "newPipelineId")
        {
            Description = @"",
        };

        public PipelinePublicServiceRenameNamespacePipelineCommand(G.IApi client) : base(
            name: "pipeline",
            description: @"Updates the ID of a pipeline. Since this is an output-only field, a custom
method is required to modify it.

The pipeline name will be updated accordingly, as it is  composed by the
parent namespace and ID of the pipeline (e.g.
`namespaces/luigi/pipelines/pizza-recipe-generator`).

The authenticated namespace must be the parent of the pipeline in order to
perform this action.")
        {
            _client = client;

            Arguments.Add(NamespaceId);
            Arguments.Add(PipelineId);
            Arguments.Add(NewPipelineId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var namespaceId = parseResult.GetRequiredValue(NamespaceId);
            var pipelineId = parseResult.GetRequiredValue(PipelineId);
            var newPipelineId = parseResult.GetRequiredValue(NewPipelineId);

            Validate(
                parseResult: parseResult,
                namespaceId: namespaceId,
                pipelineId: pipelineId,
                newPipelineId: newPipelineId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.VDP.PipelinePublicServiceRenameNamespacePipelineAsync(
                namespaceId: namespaceId,
                pipelineId: pipelineId,
                newPipelineId: newPipelineId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}