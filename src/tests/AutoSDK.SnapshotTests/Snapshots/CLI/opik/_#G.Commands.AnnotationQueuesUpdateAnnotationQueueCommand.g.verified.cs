//HintName: G.Commands.AnnotationQueuesUpdateAnnotationQueueCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AnnotationQueuesUpdateAnnotationQueueCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid id,
            string? name,
            string? description,
            string? instructions,
            bool? commentsEnabled,
            global::System.Collections.Generic.IList<string>? feedbackDefinitionNames,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> Id { get; } = new(
            name: "id")
        {
            Description = @"",
        };

        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = @"",
        };

        private new global::System.CommandLine.Option<string?> Description { get; } = new(
            name: "description")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Instructions { get; } = new(
            name: "instructions")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<bool?> CommentsEnabled { get; } = new(
            name: "commentsEnabled")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> FeedbackDefinitionNames { get; } = new(
            name: "feedbackDefinitionNames")
        {
            Description = @"",
        };


        public AnnotationQueuesUpdateAnnotationQueueCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "update",
            description: @"Update annotation queue by id")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Id);
            Options.Add(Name);
            Options.Add(Description);
            Options.Add(Instructions);
            Options.Add(CommentsEnabled);
            Options.Add(FeedbackDefinitionNames);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var id = parseResult.GetRequiredValue(Id);
            var name = parseResult.GetRequiredValue(Name);
            var description = parseResult.GetRequiredValue(Description);
            var instructions = parseResult.GetRequiredValue(Instructions);
            var commentsEnabled = parseResult.GetRequiredValue(CommentsEnabled);
            var feedbackDefinitionNames = parseResult.GetRequiredValue(FeedbackDefinitionNames);

            Validate(
                parseResult: parseResult,
                id: id,
                name: name,
                description: description,
                instructions: instructions,
                commentsEnabled: commentsEnabled,
                feedbackDefinitionNames: feedbackDefinitionNames,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.AnnotationQueues.UpdateAnnotationQueueAsync(
                id: id,
                name: name,
                description: description,
                instructions: instructions,
                commentsEnabled: commentsEnabled,
                feedbackDefinitionNames: feedbackDefinitionNames,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}