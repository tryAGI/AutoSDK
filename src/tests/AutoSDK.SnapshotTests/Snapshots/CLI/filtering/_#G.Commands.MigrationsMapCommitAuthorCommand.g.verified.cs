//HintName: G.Commands.MigrationsMapCommitAuthorCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class MigrationsMapCommitAuthorCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            int authorId,
            string? email,
            string? name,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.PorterAuthor response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Owner { get; } = new(
            name: "owner")
        {
            Description = @"The account owner of the repository. The name is not case sensitive.",
        };

        private global::System.CommandLine.Argument<string> Repo { get; } = new(
            name: "repo")
        {
            Description = @"The name of the repository without the `.git` extension. The name is not case sensitive.",
        };

        private global::System.CommandLine.Argument<int> AuthorId { get; } = new(
            name: "authorId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Email { get; } = new(
            name: "email")
        {
            Description = @"The new Git author email.",
        };

        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = @"The new Git author name.",
        };
        public MigrationsMapCommitAuthorCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "migrations",
            description: @"Update an author's identity for the import. Your application can continue updating authors any time before you push
new commits to the repository.

> [!WARNING]
> **Deprecation notice:** Due to very low levels of usage and available alternatives, this endpoint is deprecated and will no longer be available from 00:00 UTC on April 12, 2024. For more details and alternatives, see the [changelog](https://gh.io/source-imports-api-deprecation).")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(AuthorId);
            Options.Add(Email);
            Options.Add(Name);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var authorId = parseResult.GetRequiredValue(AuthorId);
            var email = parseResult.GetRequiredValue(Email);
            var name = parseResult.GetRequiredValue(Name);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                authorId: authorId,
                email: email,
                name: name,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Migrations.MigrationsMapCommitAuthorAsync(
                owner: owner,
                repo: repo,
                authorId: authorId,
                email: email,
                name: name,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}