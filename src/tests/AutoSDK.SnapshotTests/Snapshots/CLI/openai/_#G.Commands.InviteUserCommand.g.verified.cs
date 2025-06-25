//HintName: G.Commands.InviteUserCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class InviteUserCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string email,
            global::G.InviteRequestRole role,
            global::System.Collections.Generic.IList<global::G.InviteRequestProject>? projects,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.Invite response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Email { get; } = new(
            name: "email")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::G.InviteRequestRole> Role { get; } = new(
            name: "role")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.InviteRequestProject>?> Projects { get; } = new(
            name: "projects")
        {
            Description = "",
        };
        public InviteUserCommand(G.IOpenAiClient client) : base(
            name: "invite",
            description: @"")
        {
            _client = client;

            Arguments.Add(Email);
            Arguments.Add(Role);
            Options.Add(Projects);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var email = parseResult.GetRequiredValue(Email);
            var role = parseResult.GetRequiredValue(Role);
            var projects = parseResult.GetRequiredValue(Projects);

            Validate(
                parseResult: parseResult,
                email: email,
                role: role,
                projects: projects,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Invites.InviteUserAsync(
                email: email,
                role: role,
                projects: projects,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}