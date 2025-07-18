﻿//HintName: G.Commands.PipelinePublicServiceGetNamespacePipelineCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PipelinePublicServiceGetNamespacePipelineCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string namespaceId,
            string pipelineId,
            global::G.PipelinePublicServiceGetNamespacePipelineView? view,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetNamespacePipelineResponse response,
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

        private global::System.CommandLine.Option<global::G.PipelinePublicServiceGetNamespacePipelineView?> View { get; } = new(
            name: "view")
        {
            Description = @"View allows clients to specify the desired pipeline view in the response.

 - VIEW_BASIC: Default view, only includes basic information.
 - VIEW_FULL: Full representation.
 - VIEW_RECIPE: Contains the recipe of the resource.",
        };
        public PipelinePublicServiceGetNamespacePipelineCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "pipeline",
            description: @"Returns the details of a pipeline.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(NamespaceId);
            Arguments.Add(PipelineId);
            Options.Add(View);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var namespaceId = parseResult.GetRequiredValue(NamespaceId);
            var pipelineId = parseResult.GetRequiredValue(PipelineId);
            var view = parseResult.GetRequiredValue(View);

            Validate(
                parseResult: parseResult,
                namespaceId: namespaceId,
                pipelineId: pipelineId,
                view: view,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.VDP.PipelinePublicServiceGetNamespacePipelineAsync(
                namespaceId: namespaceId,
                pipelineId: pipelineId,
                view: view,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}