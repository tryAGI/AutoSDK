//HintName: G.Commands.DeleteWorkspaceMembersCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DeleteWorkspaceMembersCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string email,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.DeleteWorkspaceMemberResponseModel response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Email { get; } = new(
            name: "email")
        {
            Description = "",
        };

        public DeleteWorkspaceMembersCommand(G.IApi client) : base(
            name: "delete",
            description: @"Deletes a workspace member. This endpoint may only be called by workspace administrators.")
        {
            _client = client;

            Arguments.Add(Email);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var email = parseResult.GetRequiredValue(Email);

            Validate(
                parseResult: parseResult,
                email: email,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Workspace.DeleteWorkspaceMembersAsync(
                email: email,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}