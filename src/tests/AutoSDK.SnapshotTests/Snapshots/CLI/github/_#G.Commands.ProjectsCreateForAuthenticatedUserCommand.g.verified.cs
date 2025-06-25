//HintName: G.Commands.ProjectsCreateForAuthenticatedUserCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ProjectsCreateForAuthenticatedUserCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string name,
            string? body,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.Project response,
            global::System.Threading.CancellationToken cancellationToken);

        private new global::System.CommandLine.Argument<string> Name { get; } = new(
            name: "name")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Body { get; } = new(
            name: "body")
        {
            Description = "",
        };
        public ProjectsCreateForAuthenticatedUserCommand(G.IApi client) : base(
            name: "projects",
            description: @"Creates a user project board. Returns a `410 Gone` status if the user does not have existing classic projects. If you do not have sufficient privileges to perform this action, a `401 Unauthorized` or `410 Gone` status is returned.")
        {
            _client = client;

            Arguments.Add(Name);
            Options.Add(Body);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var name = parseResult.GetRequiredValue(Name);
            var body = parseResult.GetRequiredValue(Body);

            Validate(
                parseResult: parseResult,
                name: name,
                body: body,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Projects.ProjectsCreateForAuthenticatedUserAsync(
                name: name,
                body: body,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}