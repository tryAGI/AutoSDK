//HintName: G.Commands.UpdateUserExtensionsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UpdateUserExtensionsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

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
            Description = @"The extensions to update. The `data` field is a dictionary of extension types. The dictionary’s possible keys are: panel, overlay, or component. The key’s value is a dictionary of extensions.  
For the extension’s dictionary, the key is a sequential number beginning with 1\. For panel and overlay extensions, the key’s value is an object that contains the following fields: `active` (true/false), `id` (the extension’s ID), and `version` (the extension’s version).  
For component extensions, the key’s value includes the above fields plus the `x` and `y` fields, which identify the coordinate where the extension is placed.",
        };

        public UpdateUserExtensionsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "update",
            description: @"Updates an installed extension’s information. You can update the extension’s activation state, ID, and version number. The user ID in the access token identifies the broadcaster whose extensions you’re updating.

NOTE: If you try to activate an extension under multiple extension types, the last write wins (and there is no guarantee of write order).

__Authorization:__

Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **user:edit:broadcast** scope.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

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