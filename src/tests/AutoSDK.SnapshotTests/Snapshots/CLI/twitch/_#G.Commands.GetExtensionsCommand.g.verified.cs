//HintName: G.Commands.GetExtensionsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetExtensionsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string extensionId,
            string? extensionVersion,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetExtensionsResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ExtensionId { get; } = new(
            name: "extensionId")
        {
            Description = @"The ID of the extension to get.",
        };

        private global::System.CommandLine.Option<string?> ExtensionVersion { get; } = new(
            name: "extensionVersion")
        {
            Description = @"The version of the extension to get. If not specified, it returns the latest, released version. If you don’t have a released version, you must specify a version; otherwise, the list is empty.",
        };
        public GetExtensionsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Gets information about an extension.

__Authorization:__

Requires a signed JSON Web Token (JWT) created by an Extension Backend Service (EBS). For signing requirements, see [Signing the JWT](https://dev.twitch.tv/docs/extensions/building/#signing-the-jwt). The signed JWT must include the `role` field (see [JWT Schema](https://dev.twitch.tv/docs/extensions/reference/#jwt-schema)), and the `role` field must be set to _external_.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(ExtensionId);
            Options.Add(ExtensionVersion);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var extensionId = parseResult.GetRequiredValue(ExtensionId);
            var extensionVersion = parseResult.GetRequiredValue(ExtensionVersion);

            Validate(
                parseResult: parseResult,
                extensionId: extensionId,
                extensionVersion: extensionVersion,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Extensions.GetExtensionsAsync(
                extensionId: extensionId,
                extensionVersion: extensionVersion,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}