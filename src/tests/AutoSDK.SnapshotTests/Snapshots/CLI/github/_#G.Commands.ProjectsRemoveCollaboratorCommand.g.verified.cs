//HintName: G.Commands.ProjectsRemoveCollaboratorCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ProjectsRemoveCollaboratorCommand : global::System.CommandLine.Command
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

        public ProjectsRemoveCollaboratorCommand(G.IApi client) : base(
            name: "projects",
            description: @"Removes a collaborator from an organization project. You must be an organization owner or a project `admin` to remove a collaborator.")
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
            await _client.Projects.ProjectsRemoveCollaboratorAsync(
                projectId: projectId,
                username: username,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}