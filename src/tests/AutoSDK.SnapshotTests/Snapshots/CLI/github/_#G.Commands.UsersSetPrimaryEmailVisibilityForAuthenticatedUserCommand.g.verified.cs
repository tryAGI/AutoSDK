//HintName: G.Commands.UsersSetPrimaryEmailVisibilityForAuthenticatedUserCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UsersSetPrimaryEmailVisibilityForAuthenticatedUserCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.UsersSetPrimaryEmailVisibilityForAuthenticatedUserRequestVisibility visibility,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.Email> response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.UsersSetPrimaryEmailVisibilityForAuthenticatedUserRequestVisibility> Visibility { get; } = new(
            name: "visibility")
        {
            Description = "",
        };

        public UsersSetPrimaryEmailVisibilityForAuthenticatedUserCommand(G.IApi client) : base(
            name: "users",
            description: @"Sets the visibility for your primary email addresses.")
        {
            _client = client;

            Arguments.Add(Visibility);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var visibility = parseResult.GetRequiredValue(Visibility);

            Validate(
                parseResult: parseResult,
                visibility: visibility,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Users.UsersSetPrimaryEmailVisibilityForAuthenticatedUserAsync(
                visibility: visibility,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}