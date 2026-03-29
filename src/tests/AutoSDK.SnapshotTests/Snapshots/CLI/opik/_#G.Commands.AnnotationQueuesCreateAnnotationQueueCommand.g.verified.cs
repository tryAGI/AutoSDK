//HintName: G.Commands.AnnotationQueuesCreateAnnotationQueueCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AnnotationQueuesCreateAnnotationQueueCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid? id,
            global::System.Guid projectId,
            string name,
            string? description,
            string? instructions,
            global::G.AnnotationQueueWriteScope scope,
            bool? commentsEnabled,
            global::System.Collections.Generic.IList<string>? feedbackDefinitionNames,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> ProjectId { get; } = new(
            name: "projectId")
        {
            Description = @"",
        };

        private new global::System.CommandLine.Argument<string> Name { get; } = new(
            name: "name")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::G.AnnotationQueueWriteScope> Scope { get; } = new(
            name: "scope")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Guid?> Id { get; } = new(
            name: "id")
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


        public AnnotationQueuesCreateAnnotationQueueCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Create annotation queue for human annotation workflows")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(ProjectId);
            Arguments.Add(Name);
            Arguments.Add(Scope);
            Options.Add(Id);
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
            var projectId = parseResult.GetRequiredValue(ProjectId);
            var name = parseResult.GetRequiredValue(Name);
            var description = parseResult.GetRequiredValue(Description);
            var instructions = parseResult.GetRequiredValue(Instructions);
            var scope = parseResult.GetRequiredValue(Scope);
            var commentsEnabled = parseResult.GetRequiredValue(CommentsEnabled);
            var feedbackDefinitionNames = parseResult.GetRequiredValue(FeedbackDefinitionNames);

            Validate(
                parseResult: parseResult,
                id: id,
                projectId: projectId,
                name: name,
                description: description,
                instructions: instructions,
                scope: scope,
                commentsEnabled: commentsEnabled,
                feedbackDefinitionNames: feedbackDefinitionNames,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.AnnotationQueues.CreateAnnotationQueueAsync(
                id: id,
                projectId: projectId,
                name: name,
                description: description,
                instructions: instructions,
                scope: scope,
                commentsEnabled: commentsEnabled,
                feedbackDefinitionNames: feedbackDefinitionNames,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}