//HintName: G.Commands.UsersGetContextForUserCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UsersGetContextForUserCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string username,
            global::G.UsersGetContextForUserSubjectType? subjectType,
            string? subjectId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.Hovercard response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Username { get; } = new(
            name: "username")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.UsersGetContextForUserSubjectType?> SubjectType { get; } = new(
            name: "subjectType")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> SubjectId { get; } = new(
            name: "subjectId")
        {
            Description = "",
        };
        public UsersGetContextForUserCommand(G.IApi client) : base(
            name: "users",
            description: @"Provides hovercard information. You can find out more about someone in relation to their pull requests, issues, repositories, and organizations.

  The `subject_type` and `subject_id` parameters provide context for the person's hovercard, which returns more information than without the parameters. For example, if you wanted to find out more about `octocat` who owns the `Spoon-Knife` repository, you would use a `subject_type` value of `repository` and a `subject_id` value of `1300192` (the ID of the `Spoon-Knife` repository).

OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Username);
            Options.Add(SubjectType);
            Options.Add(SubjectId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var username = parseResult.GetRequiredValue(Username);
            var subjectType = parseResult.GetRequiredValue(SubjectType);
            var subjectId = parseResult.GetRequiredValue(SubjectId);

            Validate(
                parseResult: parseResult,
                username: username,
                subjectType: subjectType,
                subjectId: subjectId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Users.UsersGetContextForUserAsync(
                username: username,
                subjectType: subjectType,
                subjectId: subjectId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}