//HintName: G.Commands.ReposDeleteReleaseCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReposDeleteReleaseCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            int releaseId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
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

        private global::System.CommandLine.Argument<int> ReleaseId { get; } = new(
            name: "releaseId")
        {
            Description = "",
        };

        public ReposDeleteReleaseCommand(G.IApi client) : base(
            name: "repos",
            description: @"Users with push access to the repository can delete a release.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(ReleaseId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var releaseId = parseResult.GetRequiredValue(ReleaseId);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                releaseId: releaseId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Repos.ReposDeleteReleaseAsync(
                owner: owner,
                repo: repo,
                releaseId: releaseId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}