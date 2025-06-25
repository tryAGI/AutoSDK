//HintName: G.Commands.UpdateUserExtensionsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UpdateUserExtensionsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.UpdateUserExtensionsBodyData data,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.UpdateUserExtensionsResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.UpdateUserExtensionsBodyData> Data { get; } = new(
            name: "data")
        {
            Description = @"",
        };

        public UpdateUserExtensionsCommand(G.IApi client) : base(
            name: "update",
            description: @"Updates an installed extension’s information. You can update the extension’s activation state, ID, and version number. The user ID in the access token identifies the broadcaster whose extensions you’re updating.

NOTE: If you try to activate an extension under multiple extension types, the last write wins (and there is no guarantee of write order).

__Authorization:__

Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **user:edit:broadcast** scope.")
        {
            _client = client;

            Arguments.Add(Data);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var data = parseResult.GetRequiredValue(Data);

            Validate(
                parseResult: parseResult,
                data: data,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Users.UpdateUserExtensionsAsync(
                data: data,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}