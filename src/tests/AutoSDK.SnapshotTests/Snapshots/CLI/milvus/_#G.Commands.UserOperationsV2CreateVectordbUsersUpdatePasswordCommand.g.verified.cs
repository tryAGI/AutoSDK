//HintName: G.Commands.UserOperationsV2CreateVectordbUsersUpdatePasswordCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UserOperationsV2CreateVectordbUsersUpdatePasswordCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int? requestTimeout,
            string? authorization,
            string userName,
            string password,
            string newPassword1,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> UserName { get; } = new(
            name: "userName")
        {
            Description = @"The name of the target user. The value should start with a letter and can only contain underline, letters and numbers.",
        };

        private global::System.CommandLine.Argument<string> Password { get; } = new(
            name: "password")
        {
            Description = @"The corresponding password to the new user to create. 
The password must be a string of 8 to 64 characters and must include at least three of the following character types: uppercase letters, lowercase letters, numbers, and special characters.",
        };

        private global::System.CommandLine.Argument<string> NewPassword1 { get; } = new(
            name: "newPassword1")
        {
            Description = @"The new password for the specified user.    The password must be a string of 8 to 64 characters and must include at least three of the following character types: uppercase letters, lowercase letters, numbers, and special characters.",
        };

        private global::System.CommandLine.Option<int?> RequestTimeout { get; } = new(
            name: "requestTimeout")
        {
            Description = @"The timeout duration for this operation.
Setting this to None indicates that this operation timeouts when any response arrives or any error occurs.",
        };

        private global::System.CommandLine.Option<string?> Authorization { get; } = new(
            name: "authorization")
        {
            Description = @"The authorization token.",
        };


        public UserOperationsV2CreateVectordbUsersUpdatePasswordCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"This operation updates the password for a specific user.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(UserName);
            Arguments.Add(Password);
            Arguments.Add(NewPassword1);
            Options.Add(RequestTimeout);
            Options.Add(Authorization);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var requestTimeout = parseResult.GetRequiredValue(RequestTimeout);
            var authorization = parseResult.GetRequiredValue(Authorization);
            var userName = parseResult.GetRequiredValue(UserName);
            var password = parseResult.GetRequiredValue(Password);
            var newPassword1 = parseResult.GetRequiredValue(NewPassword1);

            Validate(
                parseResult: parseResult,
                requestTimeout: requestTimeout,
                authorization: authorization,
                userName: userName,
                password: password,
                newPassword1: newPassword1,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.UserOperationsV2.CreateVectordbUsersUpdatePasswordAsync(
                requestTimeout: requestTimeout,
                authorization: authorization,
                userName: userName,
                password: password,
                newPassword1: newPassword1,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}