//HintName: G.Commands.GetUserCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetUserCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string userId,
            global::G.GetUserView? view,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetUserResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> UserId { get; } = new(
            name: "userId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.GetUserView?> View { get; } = new(
            name: "view")
        {
            Description = @"",
        };
        public GetUserCommand(G.IApi client) : base(
            name: "get",
            description: @"Returns the details of a user by their ID.")
        {
            _client = client;

            Arguments.Add(UserId);
            Options.Add(View);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var userId = parseResult.GetRequiredValue(UserId);
            var view = parseResult.GetRequiredValue(View);

            Validate(
                parseResult: parseResult,
                userId: userId,
                view: view,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Namespace.GetUserAsync(
                userId: userId,
                view: view,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}