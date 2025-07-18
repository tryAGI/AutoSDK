﻿//HintName: G.Commands.PipelinePublicServiceCloneNamespacePipelineReleaseCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PipelinePublicServiceCloneNamespacePipelineReleaseCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string namespaceId,
            string pipelineId,
            string releaseId,
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
            Description = @"Namespace ID",
        };

        private global::System.CommandLine.Argument<string> PipelineId { get; } = new(
            name: "pipelineId")
        {
            Description = @"Pipeline ID",
        };

        private global::System.CommandLine.Argument<string> ReleaseId { get; } = new(
            name: "releaseId")
        {
            Description = @"Release ID",
        };

        private global::System.CommandLine.Argument<string> TargetNamespaceId { get; } = new(
            name: "targetNamespaceId")
        {
            Description = @"Target Namespace ID.",
        };

        private global::System.CommandLine.Argument<string> TargetPipelineId { get; } = new(
            name: "targetPipelineId")
        {
            Description = @"Target Pipeline ID.",
        };

        private new global::System.CommandLine.Option<string?> Description { get; } = new(
            name: "description")
        {
            Description = @"Pipeline description.",
        };

        private global::System.CommandLine.Option<global::G.Sharing?> Sharing { get; } = new(
            name: "sharing")
        {
            Description = @"Pipeline sharing information.",
        };
        public PipelinePublicServiceCloneNamespacePipelineReleaseCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "pipeline",
            description: @"Clones a pipeline release owned by a namespace. The new pipeline may have a different
parent, and this can be either a namespace or an organization.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(NamespaceId);
            Arguments.Add(PipelineId);
            Arguments.Add(ReleaseId);
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
            var releaseId = parseResult.GetRequiredValue(ReleaseId);
            var description = parseResult.GetRequiredValue(Description);
            var sharing = parseResult.GetRequiredValue(Sharing);
            var targetNamespaceId = parseResult.GetRequiredValue(TargetNamespaceId);
            var targetPipelineId = parseResult.GetRequiredValue(TargetPipelineId);

            Validate(
                parseResult: parseResult,
                namespaceId: namespaceId,
                pipelineId: pipelineId,
                releaseId: releaseId,
                description: description,
                sharing: sharing,
                targetNamespaceId: targetNamespaceId,
                targetPipelineId: targetPipelineId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.VDP.PipelinePublicServiceCloneNamespacePipelineReleaseAsync(
                namespaceId: namespaceId,
                pipelineId: pipelineId,
                releaseId: releaseId,
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