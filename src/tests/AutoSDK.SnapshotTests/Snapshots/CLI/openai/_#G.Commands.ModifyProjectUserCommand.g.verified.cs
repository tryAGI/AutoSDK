//HintName: G.Commands.ModifyProjectUserCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ModifyProjectUserCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string projectId,
            string userId,
            global::G.ProjectUserUpdateRequestRole role,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ProjectUser response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ProjectId { get; } = new(
            name: "projectId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> UserId { get; } = new(
            name: "userId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::G.ProjectUserUpdateRequestRole> Role { get; } = new(
            name: "role")
        {
            Description = "",
        };

        public ModifyProjectUserCommand(G.IOpenAiClient client) : base(
            name: "modify",
            description: @"")
        {
            _client = client;

            Arguments.Add(ProjectId);
            Arguments.Add(UserId);
            Arguments.Add(Role);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var projectId = parseResult.GetRequiredValue(ProjectId);
            var userId = parseResult.GetRequiredValue(UserId);
            var role = parseResult.GetRequiredValue(Role);

            Validate(
                parseResult: parseResult,
                projectId: projectId,
                userId: userId,
                role: role,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Projects.ModifyProjectUserAsync(
                projectId: projectId,
                userId: userId,
                role: role,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}