﻿//HintName: G.Commands.PipelinePublicServiceTriggerNamespacePipelineReleaseCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PipelinePublicServiceTriggerNamespacePipelineReleaseCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string namespaceId,
            string pipelineId,
            string releaseId,
            string? instillRequesterUid,
            global::System.Collections.Generic.IList<object>? inputs,
            global::System.Collections.Generic.IList<global::G.TriggerData>? data,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.TriggerNamespacePipelineReleaseResponse response,
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

        private global::System.CommandLine.Option<string?> InstillRequesterUid { get; } = new(
            name: "instillRequesterUid")
        {
            Description = @"Indicates the authenticated namespace is making the request on behalf of another entity, typically an organization they belong to",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<object>?> Inputs { get; } = new(
            name: "inputs")
        {
            Description = @"Pipeline input parameters, it will be deprecated soon.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.TriggerData>?> Data { get; } = new(
            name: "data")
        {
            Description = @"",
        };
        public PipelinePublicServiceTriggerNamespacePipelineReleaseCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "pipeline",
            description: @"Triggers the synchronous execution of of a pipeline. While the trigger
endpoint (where the release version isn't specified) triggers the pipeline
at its latest release, this method allows the client to specified any
committed release.

The pipeline is identified by its resource name, formed by its parent namespace
and ID.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(NamespaceId);
            Arguments.Add(PipelineId);
            Arguments.Add(ReleaseId);
            Options.Add(InstillRequesterUid);
            Options.Add(Inputs);
            Options.Add(Data);

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
            var instillRequesterUid = parseResult.GetRequiredValue(InstillRequesterUid);
            var inputs = parseResult.GetRequiredValue(Inputs);
            var data = parseResult.GetRequiredValue(Data);

            Validate(
                parseResult: parseResult,
                namespaceId: namespaceId,
                pipelineId: pipelineId,
                releaseId: releaseId,
                instillRequesterUid: instillRequesterUid,
                inputs: inputs,
                data: data,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.VDP.PipelinePublicServiceTriggerNamespacePipelineReleaseAsync(
                namespaceId: namespaceId,
                pipelineId: pipelineId,
                releaseId: releaseId,
                instillRequesterUid: instillRequesterUid,
                inputs: inputs,
                data: data,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}