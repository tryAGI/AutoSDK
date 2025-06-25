//HintName: G.Commands.SetExtensionRequiredConfigurationCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SetExtensionRequiredConfigurationCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string broadcasterId,
            string extensionId,
            string extensionVersion,
            string requiredConfiguration,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> BroadcasterId { get; } = new(
            name: "broadcasterId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> ExtensionId { get; } = new(
            name: "extensionId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> ExtensionVersion { get; } = new(
            name: "extensionVersion")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> RequiredConfiguration { get; } = new(
            name: "requiredConfiguration")
        {
            Description = "",
        };

        public SetExtensionRequiredConfigurationCommand(G.IApi client) : base(
            name: "set",
            description: @"Updates the extension’s required\_configuration string. Use this endpoint if your extension requires the broadcaster to configure the extension before activating it (to require configuration, you must select **Custom/My Own Service** in Extension [Capabilities](https://dev.twitch.tv/docs/extensions/life-cycle/#capabilities)). For more information, see [Required Configurations](https://dev.twitch.tv/docs/extensions/building#required-configurations) and [Setting Required Configuration](https://dev.twitch.tv/docs/extensions/building#setting-required-configuration-with-the-configuration-service-optional).

__Authorization:__

Requires a signed JSON Web Token (JWT) created by an EBS. For signing requirements, see [Signing the JWT](https://dev.twitch.tv/docs/extensions/building/#signing-the-jwt). The signed JWT must include the `role`, `user_id`, and `exp` fields (see [JWT Schema](https://dev.twitch.tv/docs/extensions/reference/#jwt-schema)). Set the `role` field to _external_ and the `user_id` field to the ID of the user that owns the extension.")
        {
            _client = client;

            Arguments.Add(BroadcasterId);
            Arguments.Add(ExtensionId);
            Arguments.Add(ExtensionVersion);
            Arguments.Add(RequiredConfiguration);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var broadcasterId = parseResult.GetRequiredValue(BroadcasterId);
            var extensionId = parseResult.GetRequiredValue(ExtensionId);
            var extensionVersion = parseResult.GetRequiredValue(ExtensionVersion);
            var requiredConfiguration = parseResult.GetRequiredValue(RequiredConfiguration);

            Validate(
                parseResult: parseResult,
                broadcasterId: broadcasterId,
                extensionId: extensionId,
                extensionVersion: extensionVersion,
                requiredConfiguration: requiredConfiguration,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Extensions.SetExtensionRequiredConfigurationAsync(
                broadcasterId: broadcasterId,
                extensionId: extensionId,
                extensionVersion: extensionVersion,
                requiredConfiguration: requiredConfiguration,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}