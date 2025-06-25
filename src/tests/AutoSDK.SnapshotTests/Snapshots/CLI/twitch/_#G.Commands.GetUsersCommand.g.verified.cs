//HintName: G.Commands.GetUsersCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetUsersCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<string>? id,
            global::System.Collections.Generic.IList<string>? login,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetUsersResponse response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Id { get; } = new(
            name: "id")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Login { get; } = new(
            name: "login")
        {
            Description = @"",
        };
        public GetUsersCommand(G.IApi client) : base(
            name: "get",
            description: @"Gets information about one or more users.  
You may look up users using their user ID, login name, or both but the sum total of the number of users you may look up is 100\. For example, you may specify 50 IDs and 50 names or 100 IDs or names, but you cannot specify 100 IDs and 100 names.  
If you don’t specify IDs or login names, the request returns information about the user in the access token if you specify a user access token.  
To include the user’s verified email address in the response, you must use a user access token that includes the **user:read:email** scope.

__Authorization:__

Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens) or [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens).")
        {
            _client = client;

            Options.Add(Id);
            Options.Add(Login);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var id = parseResult.GetRequiredValue(Id);
            var login = parseResult.GetRequiredValue(Login);

            Validate(
                parseResult: parseResult,
                id: id,
                login: login,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Users.GetUsersAsync(
                id: id,
                login: login,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}