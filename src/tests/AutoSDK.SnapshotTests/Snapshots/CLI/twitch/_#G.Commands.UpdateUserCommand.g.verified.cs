//HintName: G.Commands.UpdateUserCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UpdateUserCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? description,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.UpdateUserResponse response,
            global::System.Threading.CancellationToken cancellationToken);


        private new global::System.CommandLine.Option<string?> Description { get; } = new(
            name: "description")
        {
            Description = @"The string to update the channel’s description to. The description is limited to a maximum of 300 characters.  
To remove the description, specify this parameter but don’t set it’s value (for example, `?description=`).",
        };
        public UpdateUserCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "update",
            description: @"Updates the specified user’s information. The user ID in the OAuth token identifies the user whose information you want to update.

To include the user’s verified email address in the response, the user access token must also include the **user:read:email** scope.

__Authorization:__

Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **user:edit** scope.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(Description);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var description = parseResult.GetRequiredValue(Description);

            Validate(
                parseResult: parseResult,
                description: description,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Users.UpdateUserAsync(
                description: description,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}