//HintName: G.Commands.SendExtensionChatMessageCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SendExtensionChatMessageCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string broadcasterId,
            string text,
            string extensionId,
            string extensionVersion,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> BroadcasterId { get; } = new(
            name: "broadcasterId")
        {
            Description = @"The ID of the broadcaster that has activated the extension.",
        };

        private global::System.CommandLine.Argument<string> Text { get; } = new(
            name: "text")
        {
            Description = @"The message. The message may contain a maximum of 280 characters.",
        };

        private global::System.CommandLine.Argument<string> ExtensionId { get; } = new(
            name: "extensionId")
        {
            Description = @"The ID of the extension that’s sending the chat message.",
        };

        private global::System.CommandLine.Argument<string> ExtensionVersion { get; } = new(
            name: "extensionVersion")
        {
            Description = @"The extension’s version number.",
        };

        public SendExtensionChatMessageCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "send",
            description: @"Sends a message to the specified broadcaster’s chat room. The extension’s name is used as the username for the message in the chat room. To send a chat message, your extension must enable **Chat Capabilities** (under your extension’s **Capabilities** tab).

**Rate Limits**: You may send a maximum of 12 messages per minute per channel.

__Authorization:__

Requires a signed JSON Web Token (JWT) created by an Extension Backend Service (EBS). For signing requirements, see [Signing the JWT](https://dev.twitch.tv/docs/extensions/building/#signing-the-jwt). The signed JWT must include the `role` and `user_id` fields (see [JWT Schema](https://dev.twitch.tv/docs/extensions/reference/#jwt-schema)). The `role` field must be set to _external_.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(BroadcasterId);
            Arguments.Add(Text);
            Arguments.Add(ExtensionId);
            Arguments.Add(ExtensionVersion);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var broadcasterId = parseResult.GetRequiredValue(BroadcasterId);
            var text = parseResult.GetRequiredValue(Text);
            var extensionId = parseResult.GetRequiredValue(ExtensionId);
            var extensionVersion = parseResult.GetRequiredValue(ExtensionVersion);

            Validate(
                parseResult: parseResult,
                broadcasterId: broadcasterId,
                text: text,
                extensionId: extensionId,
                extensionVersion: extensionVersion,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Extensions.SendExtensionChatMessageAsync(
                broadcasterId: broadcasterId,
                text: text,
                extensionId: extensionId,
                extensionVersion: extensionVersion,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}