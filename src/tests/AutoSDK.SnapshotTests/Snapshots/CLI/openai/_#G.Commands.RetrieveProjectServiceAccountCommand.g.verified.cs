﻿//HintName: G.Commands.RetrieveProjectServiceAccountCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class RetrieveProjectServiceAccountCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string projectId,
            string serviceAccountId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ProjectServiceAccount response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ProjectId { get; } = new(
            name: "projectId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> ServiceAccountId { get; } = new(
            name: "serviceAccountId")
        {
            Description = "",
        };

        public RetrieveProjectServiceAccountCommand(G.IOpenAiClient client) : base(
            name: "retrieve",
            description: @"")
        {
            _client = client;

            Arguments.Add(ProjectId);
            Arguments.Add(ServiceAccountId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var projectId = parseResult.GetRequiredValue(ProjectId);
            var serviceAccountId = parseResult.GetRequiredValue(ServiceAccountId);

            Validate(
                parseResult: parseResult,
                projectId: projectId,
                serviceAccountId: serviceAccountId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Projects.RetrieveProjectServiceAccountAsync(
                projectId: projectId,
                serviceAccountId: serviceAccountId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}