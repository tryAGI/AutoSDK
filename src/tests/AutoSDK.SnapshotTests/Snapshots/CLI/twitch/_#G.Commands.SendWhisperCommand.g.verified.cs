﻿//HintName: G.Commands.SendWhisperCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SendWhisperCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string fromUserId,
            string toUserId,
            string message,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> FromUserId { get; } = new(
            name: "fromUserId")
        {
            Description = @"The ID of the user sending the whisper. This user must have a verified phone number. This ID must match the user ID in the user access token.",
        };

        private global::System.CommandLine.Argument<string> ToUserId { get; } = new(
            name: "toUserId")
        {
            Description = @"The ID of the user to receive the whisper.",
        };

        private global::System.CommandLine.Argument<string> Message { get; } = new(
            name: "message")
        {
            Description = @"The whisper message to send. The message must not be empty.  
The maximum message lengths are:  
* 500 characters if the user you're sending the message to hasn't whispered you before.
* 10,000 characters if the user you're sending the message to has whispered you before.
Messages that exceed the maximum length are truncated.",
        };

        public SendWhisperCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "send",
            description: @"Sends a whisper message to the specified user.

NOTE: The user sending the whisper must have a verified phone number (see the **Phone Number** setting in your [Security and Privacy](https://www.twitch.tv/settings/security) settings).

NOTE: The API may silently drop whispers that it suspects of violating Twitch policies. (The API does not indicate that it dropped the whisper; it returns a 204 status code as if it succeeded.)

**Rate Limits**: You may whisper to a maximum of 40 unique recipients per day. Within the per day limit, you may whisper a maximum of 3 whispers per second and a maximum of 100 whispers per minute.

__Authorization:__

Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **user:manage:whispers** scope.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(FromUserId);
            Arguments.Add(ToUserId);
            Arguments.Add(Message);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var fromUserId = parseResult.GetRequiredValue(FromUserId);
            var toUserId = parseResult.GetRequiredValue(ToUserId);
            var message = parseResult.GetRequiredValue(Message);

            Validate(
                parseResult: parseResult,
                fromUserId: fromUserId,
                toUserId: toUserId,
                message: message,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Whispers.SendWhisperAsync(
                fromUserId: fromUserId,
                toUserId: toUserId,
                message: message,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}