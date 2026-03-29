//HintName: G.Commands.AnnotationQueuesCreateAnnotationQueueBatchCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AnnotationQueuesCreateAnnotationQueueBatchCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.AnnotationQueueWrite> annotationQueues,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.AnnotationQueueWrite>> AnnotationQueues { get; } = new(
            name: "annotationQueues")
        {
            Description = @"List of annotation queues to create",
        };



        public AnnotationQueuesCreateAnnotationQueueBatchCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Create multiple annotation queues for human annotation workflows")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(AnnotationQueues);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var annotationQueues = parseResult.GetRequiredValue(AnnotationQueues);

            Validate(
                parseResult: parseResult,
                annotationQueues: annotationQueues,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.AnnotationQueues.CreateAnnotationQueueBatchAsync(
                annotationQueues: annotationQueues,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}