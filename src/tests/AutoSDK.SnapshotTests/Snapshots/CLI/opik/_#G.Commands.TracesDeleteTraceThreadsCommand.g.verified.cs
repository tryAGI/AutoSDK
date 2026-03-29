//HintName: G.Commands.TracesDeleteTraceThreadsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TracesDeleteTraceThreadsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? projectName,
            global::System.Guid? projectId,
            global::System.Collections.Generic.IList<string> threadIds,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<string>> ThreadIds { get; } = new(
            name: "threadIds")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> ProjectName { get; } = new(
            name: "projectName")
        {
            Description = @"If null, project_id must be provided",
        };

        private global::System.CommandLine.Option<global::System.Guid?> ProjectId { get; } = new(
            name: "projectId")
        {
            Description = @"If null, project_name must be provided",
        };


        public TracesDeleteTraceThreadsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "delete",
            description: @"Delete trace threads")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(ThreadIds);
            Options.Add(ProjectName);
            Options.Add(ProjectId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var projectName = parseResult.GetRequiredValue(ProjectName);
            var projectId = parseResult.GetRequiredValue(ProjectId);
            var threadIds = parseResult.GetRequiredValue(ThreadIds);

            Validate(
                parseResult: parseResult,
                projectName: projectName,
                projectId: projectId,
                threadIds: threadIds,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Traces.DeleteTraceThreadsAsync(
                projectName: projectName,
                projectId: projectId,
                threadIds: threadIds,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}