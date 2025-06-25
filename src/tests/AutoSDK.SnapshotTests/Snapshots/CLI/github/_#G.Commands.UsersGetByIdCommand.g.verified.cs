//HintName: G.Commands.UsersGetByIdCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UsersGetByIdCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int accountId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.OneOf<global::G.PrivateUser, global::G.PublicUser> response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<int> AccountId { get; } = new(
            name: "accountId")
        {
            Description = "",
        };

        public UsersGetByIdCommand(G.IApi client) : base(
            name: "users",
            description: @"Provides publicly available information about someone with a GitHub account. This method takes their durable user `ID` instead of their `login`, which can change over time.

The `email` key in the following response is the publicly visible email address from your GitHub [profile page](https://github.com/settings/profile). When setting up your profile, you can select a primary email address to be “public” which provides an email entry for this endpoint. If you do not set a public email address for `email`, then it will have a value of `null`. You only see publicly visible email addresses when authenticated with GitHub. For more information, see [Authentication](https://docs.github.com/rest/guides/getting-started-with-the-rest-api#authentication).

The Emails API enables you to list all of your email addresses, and toggle a primary email to be visible publicly. For more information, see ""[Emails API](https://docs.github.com/rest/users/emails)"".")
        {
            _client = client;

            Arguments.Add(AccountId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var accountId = parseResult.GetRequiredValue(AccountId);

            Validate(
                parseResult: parseResult,
                accountId: accountId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Users.UsersGetByIdAsync(
                accountId: accountId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}