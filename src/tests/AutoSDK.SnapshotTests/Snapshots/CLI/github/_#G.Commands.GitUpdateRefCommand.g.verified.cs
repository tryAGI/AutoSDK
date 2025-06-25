//HintName: G.Commands.GitUpdateRefCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GitUpdateRefCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            string @ref,
            string sha,
            bool? force,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GitRef response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Owner { get; } = new(
            name: "owner")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Repo { get; } = new(
            name: "repo")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Ref { get; } = new(
            name: "@ref")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Sha { get; } = new(
            name: "sha")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> Force { get; } = new(
            name: "force")
        {
            Description = "",
        };
        public GitUpdateRefCommand(G.IApi client) : base(
            name: "git",
            description: @"Updates the provided reference to point to a new SHA. For more information, see ""[Git References](https://git-scm.com/book/en/v2/Git-Internals-Git-References)"" in the Git documentation.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(Ref);
            Arguments.Add(Sha);
            Options.Add(Force);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var @ref = parseResult.GetRequiredValue(Ref);
            var sha = parseResult.GetRequiredValue(Sha);
            var force = parseResult.GetRequiredValue(Force);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                @ref: @ref,
                sha: sha,
                force: force,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Git.GitUpdateRefAsync(
                owner: owner,
                repo: repo,
                @ref: @ref,
                sha: sha,
                force: force,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}