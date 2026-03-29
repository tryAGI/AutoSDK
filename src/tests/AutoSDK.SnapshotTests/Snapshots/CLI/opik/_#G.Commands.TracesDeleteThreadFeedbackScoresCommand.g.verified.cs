//HintName: G.Commands.TracesDeleteThreadFeedbackScoresCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TracesDeleteThreadFeedbackScoresCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string projectName,
            string threadId,
            global::System.Collections.Generic.IList<string> names,
            string? author,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ProjectName { get; } = new(
            name: "projectName")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> ThreadId { get; } = new(
            name: "threadId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<string>> Names { get; } = new(
            name: "names")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Author { get; } = new(
            name: "author")
        {
            Description = @"",
        };


        public TracesDeleteThreadFeedbackScoresCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "delete",
            description: @"Delete thread feedback scores")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(ProjectName);
            Arguments.Add(ThreadId);
            Arguments.Add(Names);
            Options.Add(Author);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var projectName = parseResult.GetRequiredValue(ProjectName);
            var threadId = parseResult.GetRequiredValue(ThreadId);
            var names = parseResult.GetRequiredValue(Names);
            var author = parseResult.GetRequiredValue(Author);

            Validate(
                parseResult: parseResult,
                projectName: projectName,
                threadId: threadId,
                names: names,
                author: author,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Traces.DeleteThreadFeedbackScoresAsync(
                projectName: projectName,
                threadId: threadId,
                names: names,
                author: author,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}