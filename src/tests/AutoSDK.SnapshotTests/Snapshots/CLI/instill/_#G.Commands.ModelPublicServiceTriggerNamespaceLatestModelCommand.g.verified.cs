﻿//HintName: G.Commands.ModelPublicServiceTriggerNamespaceLatestModelCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ModelPublicServiceTriggerNamespaceLatestModelCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

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
            global::G.TriggerNamespaceLatestModelResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> NamespaceId { get; } = new(
            name: "namespaceId")
        {
            Description = @"Namespace ID",
        };

        private global::System.CommandLine.Argument<string> ModelId { get; } = new(
            name: "modelId")
        {
            Description = @"Model ID",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<object>> TaskInputs { get; } = new(
            name: "taskInputs")
        {
            Description = @"Model inference inputs.",
        };

        private global::System.CommandLine.Option<string?> InstillRequesterUid { get; } = new(
            name: "instillRequesterUid")
        {
            Description = @"Indicates the authenticated namespace is making the request on behalf of another entity, typically an organization they belong to",
        };
        public ModelPublicServiceTriggerNamespaceLatestModelCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "model",
            description: @"Triggers the latest deployed model version to infer the result of a set of task or
questions.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

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
            var response = await _client.Model.ModelPublicServiceTriggerNamespaceLatestModelAsync(
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