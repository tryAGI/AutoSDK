//HintName: G.Commands.ProjectsGetPermissionForUserCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ProjectsGetPermissionForUserCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int projectId,
            string username,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ProjectCollaboratorPermission response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<int> ProjectId { get; } = new(
            name: "projectId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Username { get; } = new(
            name: "username")
        {
            Description = "",
        };

        public ProjectsGetPermissionForUserCommand(G.IApi client) : base(
            name: "projects",
            description: @"Returns the collaborator's permission level for an organization project. Possible values for the `permission` key: `admin`, `write`, `read`, `none`. You must be an organization owner or a project `admin` to review a user's permission level.")
        {
            _client = client;

            Arguments.Add(ProjectId);
            Arguments.Add(Username);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var projectId = parseResult.GetRequiredValue(ProjectId);
            var username = parseResult.GetRequiredValue(Username);

            Validate(
                parseResult: parseResult,
                projectId: projectId,
                username: username,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Projects.ProjectsGetPermissionForUserAsync(
                projectId: projectId,
                username: username,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}