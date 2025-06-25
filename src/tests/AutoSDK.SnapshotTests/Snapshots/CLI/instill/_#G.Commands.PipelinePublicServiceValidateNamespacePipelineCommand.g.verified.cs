//HintName: G.Commands.PipelinePublicServiceValidateNamespacePipelineCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PipelinePublicServiceValidateNamespacePipelineCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string namespaceId,
            string pipelineId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ValidateNamespacePipelineResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> NamespaceId { get; } = new(
            name: "namespaceId")
        {
            Description = @"Namespace ID",
        };

        private global::System.CommandLine.Argument<string> PipelineId { get; } = new(
            name: "pipelineId")
        {
            Description = @"Pipeline ID",
        };

        public PipelinePublicServiceValidateNamespacePipelineCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "pipeline",
            description: @"Validates a pipeline by its resource name, which is defined by the parent
namespace and the ID of the pipeline.

Validation checks the recipe of the pipeline and the status of its components.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

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
            var response = await _client.VDP.PipelinePublicServiceValidateNamespacePipelineAsync(
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