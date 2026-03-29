//HintName: G.Commands.TracesCloseTraceThreadCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TracesCloseTraceThreadCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? projectName,
            global::System.Guid? projectId,
            string? threadId,
            global::System.Collections.Generic.IList<string>? threadIds,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<string?> ProjectName { get; } = new(
            name: "projectName")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Guid?> ProjectId { get; } = new(
            name: "projectId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> ThreadId { get; } = new(
            name: "threadId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> ThreadIds { get; } = new(
            name: "threadIds")
        {
            Description = @"",
        };


        public TracesCloseTraceThreadCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "close",
            description: @"Close one or multiple trace threads. Supports both single thread_id and multiple thread_ids for batch operations.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(ProjectName);
            Options.Add(ProjectId);
            Options.Add(ThreadId);
            Options.Add(ThreadIds);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var projectName = parseResult.GetRequiredValue(ProjectName);
            var projectId = parseResult.GetRequiredValue(ProjectId);
            var threadId = parseResult.GetRequiredValue(ThreadId);
            var threadIds = parseResult.GetRequiredValue(ThreadIds);

            Validate(
                parseResult: parseResult,
                projectName: projectName,
                projectId: projectId,
                threadId: threadId,
                threadIds: threadIds,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Traces.CloseTraceThreadAsync(
                projectName: projectName,
                projectId: projectId,
                threadId: threadId,
                threadIds: threadIds,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}