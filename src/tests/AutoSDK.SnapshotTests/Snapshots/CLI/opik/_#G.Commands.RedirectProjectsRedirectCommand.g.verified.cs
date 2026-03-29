//HintName: G.Commands.RedirectProjectsRedirectCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class RedirectProjectsRedirectCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid traceId,
            string? workspaceName,
            string path,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> TraceId { get; } = new(
            name: "traceId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> Path { get; } = new(
            name: "path")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> WorkspaceName { get; } = new(
            name: "workspaceName")
        {
            Description = @"",
        };


        public RedirectProjectsRedirectCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "projects",
            description: @"Create project redirect url")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(TraceId);
            Arguments.Add(Path);
            Options.Add(WorkspaceName);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var traceId = parseResult.GetRequiredValue(TraceId);
            var workspaceName = parseResult.GetRequiredValue(WorkspaceName);
            var path = parseResult.GetRequiredValue(Path);

            Validate(
                parseResult: parseResult,
                traceId: traceId,
                workspaceName: workspaceName,
                path: path,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Redirect.ProjectsRedirectAsync(
                traceId: traceId,
                workspaceName: workspaceName,
                path: path,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}