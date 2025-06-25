//HintName: G.Commands.PipelinePublicServiceTriggerNamespacePipelineCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PipelinePublicServiceTriggerNamespacePipelineCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string namespaceId,
            string pipelineId,
            string? instillRequesterUid,
            global::System.Collections.Generic.IList<object> inputs,
            global::System.Collections.Generic.IList<global::G.TriggerData> data,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.TriggerNamespacePipelineResponse response,
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

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<object>> Inputs { get; } = new(
            name: "inputs")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.TriggerData>> Data { get; } = new(
            name: "data")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> InstillRequesterUid { get; } = new(
            name: "instillRequesterUid")
        {
            Description = "",
        };
        public PipelinePublicServiceTriggerNamespacePipelineCommand(G.IApi client) : base(
            name: "pipeline",
            description: @"Triggers the execution of a pipeline synchronously, i.e., the result is
sent back to the namespace right after the data is processed. This method is
intended for real-time inference when low latency is of concern.

The pipeline is identified by its resource name, formed by the parent namespace
and ID of the pipeline.

For more information, see [Run NamespacePipeline](https://www.instill.tech/docs/vdp/run).")
        {
            _client = client;

            Arguments.Add(NamespaceId);
            Arguments.Add(PipelineId);
            Arguments.Add(Inputs);
            Arguments.Add(Data);
            Options.Add(InstillRequesterUid);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var namespaceId = parseResult.GetRequiredValue(NamespaceId);
            var pipelineId = parseResult.GetRequiredValue(PipelineId);
            var instillRequesterUid = parseResult.GetRequiredValue(InstillRequesterUid);
            var inputs = parseResult.GetRequiredValue(Inputs);
            var data = parseResult.GetRequiredValue(Data);

            Validate(
                parseResult: parseResult,
                namespaceId: namespaceId,
                pipelineId: pipelineId,
                instillRequesterUid: instillRequesterUid,
                inputs: inputs,
                data: data,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.VDP.PipelinePublicServiceTriggerNamespacePipelineAsync(
                namespaceId: namespaceId,
                pipelineId: pipelineId,
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