//HintName: G.Commands.ProjectsUpdateCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ProjectsUpdateCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int projectId,
            string? name,
            string? body,
            string? state,
            global::G.ProjectsUpdateRequestOrganizationPermission? organizationPermission,
            bool? @private,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.Project response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<int> ProjectId { get; } = new(
            name: "projectId")
        {
            Description = "",
        };

        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Body { get; } = new(
            name: "body")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> State { get; } = new(
            name: "state")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ProjectsUpdateRequestOrganizationPermission?> OrganizationPermission { get; } = new(
            name: "organizationPermission")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> Private { get; } = new(
            name: "@private")
        {
            Description = "",
        };
        public ProjectsUpdateCommand(G.IApi client) : base(
            name: "projects",
            description: @"Updates a project board's information. Returns a `404 Not Found` status if projects are disabled. If you do not have sufficient privileges to perform this action, a `401 Unauthorized` or `410 Gone` status is returned.")
        {
            _client = client;

            Arguments.Add(ProjectId);
            Options.Add(Name);
            Options.Add(Body);
            Options.Add(State);
            Options.Add(OrganizationPermission);
            Options.Add(Private);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var projectId = parseResult.GetRequiredValue(ProjectId);
            var name = parseResult.GetRequiredValue(Name);
            var body = parseResult.GetRequiredValue(Body);
            var state = parseResult.GetRequiredValue(State);
            var organizationPermission = parseResult.GetRequiredValue(OrganizationPermission);
            var @private = parseResult.GetRequiredValue(Private);

            Validate(
                parseResult: parseResult,
                projectId: projectId,
                name: name,
                body: body,
                state: state,
                organizationPermission: organizationPermission,
                @private: @private,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Projects.ProjectsUpdateAsync(
                projectId: projectId,
                name: name,
                body: body,
                state: state,
                organizationPermission: organizationPermission,
                @private: @private,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}