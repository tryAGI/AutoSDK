﻿//HintName: G.Commands.CodespacesGetSecretForAuthenticatedUserCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CodespacesGetSecretForAuthenticatedUserCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string secretName,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.CodespacesSecret response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> SecretName { get; } = new(
            name: "secretName")
        {
            Description = "",
        };

        public CodespacesGetSecretForAuthenticatedUserCommand(G.IApi client) : base(
            name: "codespaces",
            description: @"Gets a development environment secret available to a user's codespaces without revealing its encrypted value.

The authenticated user must have Codespaces access to use this endpoint.

OAuth app tokens and personal access tokens (classic) need the `codespace` or `codespace:secrets` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(SecretName);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var secretName = parseResult.GetRequiredValue(SecretName);

            Validate(
                parseResult: parseResult,
                secretName: secretName,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Codespaces.CodespacesGetSecretForAuthenticatedUserAsync(
                secretName: secretName,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}