﻿//HintName: G.Commands.RetrieveProjectApiKeyCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class RetrieveProjectApiKeyCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string projectId,
            string keyId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ProjectApiKey response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ProjectId { get; } = new(
            name: "projectId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> KeyId { get; } = new(
            name: "keyId")
        {
            Description = "",
        };

        public RetrieveProjectApiKeyCommand(G.IOpenAiClient client) : base(
            name: "retrieve",
            description: @"")
        {
            _client = client;

            Arguments.Add(ProjectId);
            Arguments.Add(KeyId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var projectId = parseResult.GetRequiredValue(ProjectId);
            var keyId = parseResult.GetRequiredValue(KeyId);

            Validate(
                parseResult: parseResult,
                projectId: projectId,
                keyId: keyId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Projects.RetrieveProjectApiKeyAsync(
                projectId: projectId,
                keyId: keyId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}