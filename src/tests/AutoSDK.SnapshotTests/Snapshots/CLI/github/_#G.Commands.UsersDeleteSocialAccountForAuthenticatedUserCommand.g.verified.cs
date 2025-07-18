﻿//HintName: G.Commands.UsersDeleteSocialAccountForAuthenticatedUserCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UsersDeleteSocialAccountForAuthenticatedUserCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<string> accountUrls,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<string>> AccountUrls { get; } = new(
            name: "accountUrls")
        {
            Description = "",
        };

        public UsersDeleteSocialAccountForAuthenticatedUserCommand(G.IApi client) : base(
            name: "users",
            description: @"Deletes one or more social accounts from the authenticated user's profile.

OAuth app tokens and personal access tokens (classic) need the `user` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(AccountUrls);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var accountUrls = parseResult.GetRequiredValue(AccountUrls);

            Validate(
                parseResult: parseResult,
                accountUrls: accountUrls,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Users.UsersDeleteSocialAccountForAuthenticatedUserAsync(
                accountUrls: accountUrls,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}