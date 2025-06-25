//HintName: G.Commands.SendExtensionPubsubMessageCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SendExtensionPubsubMessageCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.SendExtensionPubSubMessageBodyTargetItem> target,
            string broadcasterId,
            bool? isGlobalBroadcast,
            string message,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.SendExtensionPubSubMessageBodyTargetItem>> Target { get; } = new(
            name: "target")
        {
            Description = @"The target of the message. Possible values are:  
* broadcast
* global
* whisper-<user-id>
If `is_global_broadcast` is **true**, you must set this field to global. The broadcast and global values are mutually exclusive; specify only one of them.",
        };

        private global::System.CommandLine.Argument<string> BroadcasterId { get; } = new(
            name: "broadcasterId")
        {
            Description = @"The ID of the broadcaster to send the message to. Don’t include this field if `is_global_broadcast` is set to **true**.",
        };

        private global::System.CommandLine.Argument<string> Message { get; } = new(
            name: "message")
        {
            Description = @"The message to send. The message can be a plain-text string or a string-encoded JSON object. The message is limited to a maximum of 5 KB.",
        };

        private global::System.CommandLine.Option<bool?> IsGlobalBroadcast { get; } = new(
            name: "isGlobalBroadcast")
        {
            Description = @"A Boolean value that determines whether the message should be sent to all channels where your extension is active. Set to **true** if the message should be sent to all channels. The default is **false**.",
        };
        public SendExtensionPubsubMessageCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "send",
            description: @"Sends a message to one or more viewers. You can send messages to a specific channel or to all channels where your extension is active. This endpoint uses the same mechanism as the [send](https://dev.twitch.tv/docs/extensions/reference#send) JavaScript helper function used to send messages.

**Rate Limits**: You may send a maximum of 100 messages per minute per combination of extension client ID and broadcaster ID.

__Authorization:__

Requires a signed JSON Web Token (JWT) created by an Extension Backend Service (EBS). For signing requirements, see [Signing the JWT](https://dev.twitch.tv/docs/extensions/building/#signing-the-jwt). The signed JWT must include the `role`, `user_id`, and `exp` fields (see [JWT Schema](https://dev.twitch.tv/docs/extensions/reference/#jwt-schema)) along with the `channel_id` and `pubsub_perms` fields. The `role` field must be set to _external_.

To send the message to a specific channel, set the `channel_id` field in the JWT to the channel’s ID and set the `pubsub_perms.send` array to _broadcast_.

```
{
  ""exp"": 1503343947,
  ""user_id"": ""27419011"",
  ""role"": ""external"",
  ""channel_id"": ""27419011"",
  ""pubsub_perms"": {
    ""send"":[
      ""broadcast""
    ]
  }
}

```

To send the message to all channels on which your extension is active, set the `channel_id` field to _all_ and set the `pubsub_perms.send` array to _global_.

```
{
  ""exp"": 1503343947,
  ""user_id"": ""27419011"",
  ""role"": ""external"",
  ""channel_id"": ""all"",
  ""pubsub_perms"": {
    ""send"":[
      ""global""
    ]
  }
}

```")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Target);
            Arguments.Add(BroadcasterId);
            Arguments.Add(Message);
            Options.Add(IsGlobalBroadcast);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var target = parseResult.GetRequiredValue(Target);
            var broadcasterId = parseResult.GetRequiredValue(BroadcasterId);
            var isGlobalBroadcast = parseResult.GetRequiredValue(IsGlobalBroadcast);
            var message = parseResult.GetRequiredValue(Message);

            Validate(
                parseResult: parseResult,
                target: target,
                broadcasterId: broadcasterId,
                isGlobalBroadcast: isGlobalBroadcast,
                message: message,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Extensions.SendExtensionPubsubMessageAsync(
                target: target,
                broadcasterId: broadcasterId,
                isGlobalBroadcast: isGlobalBroadcast,
                message: message,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}