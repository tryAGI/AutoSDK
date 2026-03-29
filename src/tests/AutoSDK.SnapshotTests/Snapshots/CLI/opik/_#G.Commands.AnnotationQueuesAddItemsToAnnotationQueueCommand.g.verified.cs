//HintName: G.Commands.AnnotationQueuesAddItemsToAnnotationQueueCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AnnotationQueuesAddItemsToAnnotationQueueCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid id,
            global::System.Collections.Generic.IList<global::System.Guid> ids,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> Id { get; } = new(
            name: "id")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::System.Guid>> Ids { get; } = new(
            name: "ids")
        {
            Description = @"",
        };



        public AnnotationQueuesAddItemsToAnnotationQueueCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "add",
            description: @"Add traces or threads to annotation queue")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Id);
            Arguments.Add(Ids);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var id = parseResult.GetRequiredValue(Id);
            var ids = parseResult.GetRequiredValue(Ids);

            Validate(
                parseResult: parseResult,
                id: id,
                ids: ids,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.AnnotationQueues.AddItemsToAnnotationQueueAsync(
                id: id,
                ids: ids,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}