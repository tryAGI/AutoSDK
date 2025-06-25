//HintName: G.Commands.GetExtensionConfigurationSegmentCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetExtensionConfigurationSegmentCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

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
            Description = @"The ID of the extension that contains the configuration segment you want to get.",
        };

        private global::System.CommandLine.Argument<global::G.GetExtensionConfigurationSegmentSegment> Segment { get; } = new(
            name: "segment")
        {
            Description = @"The type of configuration segment to get. Possible case-sensitive values are:   
* broadcaster
* developer
* global
You may specify one or more segments. To specify multiple segments, include the `segment` parameter for each segment to get. For example, `segment=broadcaster&segment=developer`. Ignores duplicate segments.",
        };

        private global::System.CommandLine.Option<string?> BroadcasterId { get; } = new(
            name: "broadcasterId")
        {
            Description = @"The ID of the broadcaster that installed the extension. This parameter is required if you set the _segment_ parameter to broadcaster or developer. Do not specify this parameter if you set _segment_ to global.",
        };
        public GetExtensionConfigurationSegmentCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Gets the specified configuration segment from the specified extension.

**Rate Limits**: You may retrieve each segment a maximum of 20 times per minute.

__Authorization:__

Requires a signed JSON Web Token (JWT) created by an Extension Backend Service (EBS). For signing requirements, see [Signing the JWT](https://dev.twitch.tv/docs/extensions/building/#signing-the-jwt). The signed JWT must include the `role`, `user_id`, and `exp` fields (see [JWT Schema](https://dev.twitch.tv/docs/extensions/reference/#jwt-schema)). The `role` field must be set to _external_.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

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