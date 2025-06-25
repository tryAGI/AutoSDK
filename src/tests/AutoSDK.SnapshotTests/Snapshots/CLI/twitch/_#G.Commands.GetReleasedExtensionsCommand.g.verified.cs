//HintName: G.Commands.GetReleasedExtensionsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetReleasedExtensionsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string extensionId,
            string? extensionVersion,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetReleasedExtensionsResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ExtensionId { get; } = new(
            name: "extensionId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> ExtensionVersion { get; } = new(
            name: "extensionVersion")
        {
            Description = "",
        };
        public GetReleasedExtensionsCommand(G.IApi client) : base(
            name: "get",
            description: @"Gets information about a released extension. Returns the extension if its `state` is Released.

__Authorization:__

Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens) or [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens).")
        {
            _client = client;

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
            var response = await _client.Extensions.GetReleasedExtensionsAsync(
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