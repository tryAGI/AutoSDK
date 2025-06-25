//HintName: G.Commands.ModelPublicServiceTriggerAsyncNamespaceLatestModelCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ModelPublicServiceTriggerAsyncNamespaceLatestModelCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string namespaceId,
            string modelId,
            string? instillRequesterUid,
            global::System.Collections.Generic.IList<object> taskInputs,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.TriggerAsyncNamespaceLatestModelResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> NamespaceId { get; } = new(
            name: "namespaceId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> ModelId { get; } = new(
            name: "modelId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<object>> TaskInputs { get; } = new(
            name: "taskInputs")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> InstillRequesterUid { get; } = new(
            name: "instillRequesterUid")
        {
            Description = @"",
        };
        public ModelPublicServiceTriggerAsyncNamespaceLatestModelCommand(G.IApi client) : base(
            name: "model",
            description: @"Triggers the latest deployed model version to infer the result of a set of task or
questions.")
        {
            _client = client;

            Arguments.Add(NamespaceId);
            Arguments.Add(ModelId);
            Arguments.Add(TaskInputs);
            Options.Add(InstillRequesterUid);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var namespaceId = parseResult.GetRequiredValue(NamespaceId);
            var modelId = parseResult.GetRequiredValue(ModelId);
            var instillRequesterUid = parseResult.GetRequiredValue(InstillRequesterUid);
            var taskInputs = parseResult.GetRequiredValue(TaskInputs);

            Validate(
                parseResult: parseResult,
                namespaceId: namespaceId,
                modelId: modelId,
                instillRequesterUid: instillRequesterUid,
                taskInputs: taskInputs,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Model.ModelPublicServiceTriggerAsyncNamespaceLatestModelAsync(
                namespaceId: namespaceId,
                modelId: modelId,
                instillRequesterUid: instillRequesterUid,
                taskInputs: taskInputs,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}