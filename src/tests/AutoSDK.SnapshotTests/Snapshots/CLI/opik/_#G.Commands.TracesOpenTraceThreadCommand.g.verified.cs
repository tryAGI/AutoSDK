//HintName: G.Commands.TracesOpenTraceThreadCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TracesOpenTraceThreadCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? projectName,
            global::System.Guid? projectId,
            string threadId,
            bool? truncate,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ThreadId { get; } = new(
            name: "threadId")
        {
            Description = @"",
        };

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

        private global::System.CommandLine.Option<bool?> Truncate { get; } = new(
            name: "truncate")
        {
            Description = @"",
        };


        public TracesOpenTraceThreadCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "open",
            description: @"Open trace thread")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(ThreadId);
            Options.Add(ProjectName);
            Options.Add(ProjectId);
            Options.Add(Truncate);

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
            var truncate = parseResult.GetRequiredValue(Truncate);

            Validate(
                parseResult: parseResult,
                projectName: projectName,
                projectId: projectId,
                threadId: threadId,
                truncate: truncate,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Traces.OpenTraceThreadAsync(
                projectName: projectName,
                projectId: projectId,
                threadId: threadId,
                truncate: truncate,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}