//HintName: G.Commands.ProjectsAddCollaboratorCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ProjectsAddCollaboratorCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int projectId,
            string username,
            global::G.ProjectsAddCollaboratorRequestPermission? permission,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
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

        private global::System.CommandLine.Option<global::G.ProjectsAddCollaboratorRequestPermission?> Permission { get; } = new(
            name: "permission")
        {
            Description = "",
        };
        public ProjectsAddCollaboratorCommand(G.IApi client) : base(
            name: "projects",
            description: @"Adds a collaborator to an organization project and sets their permission level. You must be an organization owner or a project `admin` to add a collaborator.")
        {
            _client = client;

            Arguments.Add(ProjectId);
            Arguments.Add(Username);
            Options.Add(Permission);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var projectId = parseResult.GetRequiredValue(ProjectId);
            var username = parseResult.GetRequiredValue(Username);
            var permission = parseResult.GetRequiredValue(Permission);

            Validate(
                parseResult: parseResult,
                projectId: projectId,
                username: username,
                permission: permission,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Projects.ProjectsAddCollaboratorAsync(
                projectId: projectId,
                username: username,
                permission: permission,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}