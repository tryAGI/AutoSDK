//HintName: G.Commands.GetExtensionConfigurationSegmentCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetExtensionConfigurationSegmentCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? broadcasterId,
            string extensionId,
            global::G.GetExtensionConfigurationSegmentSegment segment,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetExtensionConfigurationSegmentResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ExtensionId { get; } = new(
            name: "extensionId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::G.GetExtensionConfigurationSegmentSegment> Segment { get; } = new(
            name: "segment")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> BroadcasterId { get; } = new(
            name: "broadcasterId")
        {
            Description = @"",
        };
        public GetExtensionConfigurationSegmentCommand(G.IApi client) : base(
            name: "get",
            description: @"Gets the specified configuration segment from the specified extension.

**Rate Limits**: You may retrieve each segment a maximum of 20 times per minute.

__Authorization:__

Requires a signed JSON Web Token (JWT) created by an Extension Backend Service (EBS). For signing requirements, see [Signing the JWT](https://dev.twitch.tv/docs/extensions/building/#signing-the-jwt). The signed JWT must include the `role`, `user_id`, and `exp` fields (see [JWT Schema](https://dev.twitch.tv/docs/extensions/reference/#jwt-schema)). The `role` field must be set to _external_.")
        {
            _client = client;

            Arguments.Add(ExtensionId);
            Arguments.Add(Segment);
            Options.Add(BroadcasterId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var broadcasterId = parseResult.GetRequiredValue(BroadcasterId);
            var extensionId = parseResult.GetRequiredValue(ExtensionId);
            var segment = parseResult.GetRequiredValue(Segment);

            Validate(
                parseResult: parseResult,
                broadcasterId: broadcasterId,
                extensionId: extensionId,
                segment: segment,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Extensions.GetExtensionConfigurationSegmentAsync(
                broadcasterId: broadcasterId,
                extensionId: extensionId,
                segment: segment,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}