﻿//HintName: G.Commands.UnblockUserCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UnblockUserCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string targetUserId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> TargetUserId { get; } = new(
            name: "targetUserId")
        {
            Description = @"The ID of the user to remove from the broadcaster’s list of blocked users. The API ignores the request if the broadcaster hasn’t blocked the user.",
        };

        public UnblockUserCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "unblock",
            description: @"Removes the user from the broadcaster’s list of blocked users. The user ID in the OAuth token identifies the broadcaster who’s removing the block.

__Authorization:__

Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **user:manage:blocked\_users** scope.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(TargetUserId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var targetUserId = parseResult.GetRequiredValue(TargetUserId);

            Validate(
                parseResult: parseResult,
                targetUserId: targetUserId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Users.UnblockUserAsync(
                targetUserId: targetUserId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}