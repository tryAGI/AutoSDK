//HintName: G.Commands.SetExtensionConfigurationSegmentCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SetExtensionConfigurationSegmentCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string extensionId,
            global::G.SetExtensionConfigurationSegmentBodySegment segment,
            string? broadcasterId,
            string? content,
            string? version,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ExtensionId { get; } = new(
            name: "extensionId")
        {
            Description = @"The ID of the extension to update.",
        };

        private global::System.CommandLine.Argument<global::G.SetExtensionConfigurationSegmentBodySegment> Segment { get; } = new(
            name: "segment")
        {
            Description = @"The configuration segment to update. Possible case-sensitive values are:  
* broadcaster
* developer
* global",
        };

        private global::System.CommandLine.Option<string?> BroadcasterId { get; } = new(
            name: "broadcasterId")
        {
            Description = @"The ID of the broadcaster that installed the extension. Include this field only if the `segment` is set to developer or broadcaster.",
        };

        private global::System.CommandLine.Option<string?> Content { get; } = new(
            name: "content")
        {
            Description = @"The contents of the segment. This string may be a plain-text string or a string-encoded JSON object.",
        };

        private global::System.CommandLine.Option<string?> Version { get; } = new(
            name: "version")
        {
            Description = @"The version number that identifies this definition of the segment’s data. If not specified, the latest definition is updated.",
        };
        public SetExtensionConfigurationSegmentCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "set",
            description: @"Updates a configuration segment. The segment is limited to 5 KB. Extensions that are active on a channel do not receive the updated configuration.

**Rate Limits**: You may update the configuration a maximum of 20 times per minute.

__Authorization:__

Requires a signed JSON Web Token (JWT) created by an Extension Backend Service (EBS). For signing requirements, see [Signing the JWT](https://dev.twitch.tv/docs/extensions/building/#signing-the-jwt). The signed JWT must include the `role`, `user_id`, and `exp` fields (see [JWT Schema](https://dev.twitch.tv/docs/extensions/reference/#jwt-schema)). The `role` field must be set to _external_.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(ExtensionId);
            Arguments.Add(Segment);
            Options.Add(BroadcasterId);
            Options.Add(Content);
            Options.Add(Version);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var extensionId = parseResult.GetRequiredValue(ExtensionId);
            var segment = parseResult.GetRequiredValue(Segment);
            var broadcasterId = parseResult.GetRequiredValue(BroadcasterId);
            var content = parseResult.GetRequiredValue(Content);
            var version = parseResult.GetRequiredValue(Version);

            Validate(
                parseResult: parseResult,
                extensionId: extensionId,
                segment: segment,
                broadcasterId: broadcasterId,
                content: content,
                version: version,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Extensions.SetExtensionConfigurationSegmentAsync(
                extensionId: extensionId,
                segment: segment,
                broadcasterId: broadcasterId,
                content: content,
                version: version,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}