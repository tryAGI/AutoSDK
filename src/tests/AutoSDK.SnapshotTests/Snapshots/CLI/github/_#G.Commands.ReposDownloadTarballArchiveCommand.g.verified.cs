//HintName: G.Commands.ReposDownloadTarballArchiveCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReposDownloadTarballArchiveCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            string @ref,
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

        private global::System.CommandLine.Argument<string> Ref { get; } = new(
            name: "@ref")
        {
            Description = "",
        };

        public ReposDownloadTarballArchiveCommand(G.IApi client) : base(
            name: "repos",
            description: @"Gets a redirect URL to download a tar archive for a repository. If you omit `:ref`, the repository’s default branch (usually
`main`) will be used. Please make sure your HTTP framework is configured to follow redirects or you will need to use
the `Location` header to make a second `GET` request.

> [!NOTE]
> For private repositories, these links are temporary and expire after five minutes.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(Ref);

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

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                @ref: @ref,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Repos.ReposDownloadTarballArchiveAsync(
                owner: owner,
                repo: repo,
                @ref: @ref,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}