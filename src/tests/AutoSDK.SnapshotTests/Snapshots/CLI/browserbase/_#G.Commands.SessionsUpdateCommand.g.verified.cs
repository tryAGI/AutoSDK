//HintName: G.Commands.SessionsUpdateCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SessionsUpdateCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string id,
            string? projectId,
            global::G.SessionsUpdateRequestStatus status,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.Session response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Id { get; } = new(
            name: "id")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> ProjectId { get; } = new(
            name: "projectId")
        {
            Description = @"The Project ID. Can be found in [Settings](https://www.browserbase.com/settings). Optional - if not provided, the project will be inferred from the API key.",
        };

        private global::System.CommandLine.Option<global::G.SessionsUpdateRequestStatus> Status { get; } = new(
            name: "status")
        {
            Description = @"Set to `REQUEST_RELEASE` to request that the session complete. Use before session's timeout to avoid additional charges.",
        };


        public SessionsUpdateCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "sessions",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Id);
            Options.Add(ProjectId);
            Options.Add(Status);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var id = parseResult.GetRequiredValue(Id);
            var projectId = parseResult.GetRequiredValue(ProjectId);
            var status = parseResult.GetRequiredValue(Status);

            Validate(
                parseResult: parseResult,
                id: id,
                projectId: projectId,
                status: status,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.SessionsUpdateAsync(
                id: id,
                projectId: projectId,
                status: status,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}