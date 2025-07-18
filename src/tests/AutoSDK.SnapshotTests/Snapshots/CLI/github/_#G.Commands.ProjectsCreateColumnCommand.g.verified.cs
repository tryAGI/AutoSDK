﻿//HintName: G.Commands.ProjectsCreateColumnCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ProjectsCreateColumnCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int projectId,
            string name,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ProjectColumn response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<int> ProjectId { get; } = new(
            name: "projectId")
        {
            Description = "",
        };

        private new global::System.CommandLine.Argument<string> Name { get; } = new(
            name: "name")
        {
            Description = "",
        };

        public ProjectsCreateColumnCommand(G.IApi client) : base(
            name: "projects",
            description: @"Creates a new project column.")
        {
            _client = client;

            Arguments.Add(ProjectId);
            Arguments.Add(Name);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var projectId = parseResult.GetRequiredValue(ProjectId);
            var name = parseResult.GetRequiredValue(Name);

            Validate(
                parseResult: parseResult,
                projectId: projectId,
                name: name,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Projects.ProjectsCreateColumnAsync(
                projectId: projectId,
                name: name,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}