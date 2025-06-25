//HintName: G.Commands.GetProjectsByProjectIdCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetProjectsByProjectIdCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string projectId,
            string? xiApiKey,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ProjectExtendedResponseModel response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ProjectId { get; } = new(
            name: "projectId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };
        public GetProjectsByProjectIdCommand(G.IApi client) : base(
            name: "get",
            description: @"Returns information about a specific project. This endpoint returns more detailed information about a project than `GET /v1/projects`.")
        {
            _client = client;

            Arguments.Add(ProjectId);
            Options.Add(XiApiKey);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var projectId = parseResult.GetRequiredValue(ProjectId);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);

            Validate(
                parseResult: parseResult,
                projectId: projectId,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Projects.GetProjectsByProjectIdAsync(
                projectId: projectId,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}