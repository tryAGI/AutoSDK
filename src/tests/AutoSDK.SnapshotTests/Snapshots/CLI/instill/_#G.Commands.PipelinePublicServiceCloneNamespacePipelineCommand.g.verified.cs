//HintName: G.Commands.PipelinePublicServiceCloneNamespacePipelineCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PipelinePublicServiceCloneNamespacePipelineCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string namespaceId,
            string pipelineId,
            string? description,
            global::G.Sharing? sharing,
            string targetNamespaceId,
            string targetPipelineId,
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

        private global::System.CommandLine.Argument<string> TargetNamespaceId { get; } = new(
            name: "targetNamespaceId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> TargetPipelineId { get; } = new(
            name: "targetPipelineId")
        {
            Description = "",
        };

        private new global::System.CommandLine.Option<string?> Description { get; } = new(
            name: "description")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.Sharing?> Sharing { get; } = new(
            name: "sharing")
        {
            Description = "",
        };
        public PipelinePublicServiceCloneNamespacePipelineCommand(G.IApi client) : base(
            name: "pipeline",
            description: @"Clones a pipeline owned by a namespace. The new pipeline may have a different
parent, and this can be either a namespace or an organization.")
        {
            _client = client;

            Arguments.Add(NamespaceId);
            Arguments.Add(PipelineId);
            Arguments.Add(TargetNamespaceId);
            Arguments.Add(TargetPipelineId);
            Options.Add(Description);
            Options.Add(Sharing);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var namespaceId = parseResult.GetRequiredValue(NamespaceId);
            var pipelineId = parseResult.GetRequiredValue(PipelineId);
            var description = parseResult.GetRequiredValue(Description);
            var sharing = parseResult.GetRequiredValue(Sharing);
            var targetNamespaceId = parseResult.GetRequiredValue(TargetNamespaceId);
            var targetPipelineId = parseResult.GetRequiredValue(TargetPipelineId);

            Validate(
                parseResult: parseResult,
                namespaceId: namespaceId,
                pipelineId: pipelineId,
                description: description,
                sharing: sharing,
                targetNamespaceId: targetNamespaceId,
                targetPipelineId: targetPipelineId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.VDP.PipelinePublicServiceCloneNamespacePipelineAsync(
                namespaceId: namespaceId,
                pipelineId: pipelineId,
                description: description,
                sharing: sharing,
                targetNamespaceId: targetNamespaceId,
                targetPipelineId: targetPipelineId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}