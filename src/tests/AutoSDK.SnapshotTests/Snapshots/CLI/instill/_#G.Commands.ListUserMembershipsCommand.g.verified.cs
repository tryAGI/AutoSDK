//HintName: G.Commands.ListUserMembershipsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ListUserMembershipsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string userId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ListUserMembershipsResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> UserId { get; } = new(
            name: "userId")
        {
            Description = @"User ID",
        };

        public ListUserMembershipsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "list",
            description: @"Returns the memberships of a user.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(UserId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var userId = parseResult.GetRequiredValue(UserId);

            Validate(
                parseResult: parseResult,
                userId: userId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Namespace.ListUserMembershipsAsync(
                userId: userId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}