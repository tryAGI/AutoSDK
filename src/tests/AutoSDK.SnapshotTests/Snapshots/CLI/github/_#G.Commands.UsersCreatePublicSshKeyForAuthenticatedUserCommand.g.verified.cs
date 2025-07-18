﻿//HintName: G.Commands.UsersCreatePublicSshKeyForAuthenticatedUserCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UsersCreatePublicSshKeyForAuthenticatedUserCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? title,
            string key,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.Key response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Key { get; } = new(
            name: "key")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Title { get; } = new(
            name: "title")
        {
            Description = "",
        };
        public UsersCreatePublicSshKeyForAuthenticatedUserCommand(G.IApi client) : base(
            name: "users",
            description: @"Adds a public SSH key to the authenticated user's GitHub account.

OAuth app tokens and personal access tokens (classic) need the `write:gpg_key` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Key);
            Options.Add(Title);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var title = parseResult.GetRequiredValue(Title);
            var key = parseResult.GetRequiredValue(Key);

            Validate(
                parseResult: parseResult,
                title: title,
                key: key,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Users.UsersCreatePublicSshKeyForAuthenticatedUserAsync(
                title: title,
                key: key,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}