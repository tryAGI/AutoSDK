//HintName: G.Commands.ReposCreateForkCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReposCreateForkCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            string? organization,
            string? name,
            bool? defaultBranchOnly,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.FullRepository response,
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

        private global::System.CommandLine.Option<string?> Organization { get; } = new(
            name: "organization")
        {
            Description = "",
        };

        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> DefaultBranchOnly { get; } = new(
            name: "defaultBranchOnly")
        {
            Description = "",
        };
        public ReposCreateForkCommand(G.IApi client) : base(
            name: "repos",
            description: @"Create a fork for the authenticated user.

> [!NOTE]
> Forking a Repository happens asynchronously. You may have to wait a short period of time before you can access the git objects. If this takes longer than 5 minutes, be sure to contact [GitHub Support](https://support.github.com/contact?tags=dotcom-rest-api).

> [!NOTE]
> Although this endpoint works with GitHub Apps, the GitHub App must be installed on the destination account with access to all repositories and on the source account with access to the source repository.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Options.Add(Organization);
            Options.Add(Name);
            Options.Add(DefaultBranchOnly);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var organization = parseResult.GetRequiredValue(Organization);
            var name = parseResult.GetRequiredValue(Name);
            var defaultBranchOnly = parseResult.GetRequiredValue(DefaultBranchOnly);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                organization: organization,
                name: name,
                defaultBranchOnly: defaultBranchOnly,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Repos.ReposCreateForkAsync(
                owner: owner,
                repo: repo,
                organization: organization,
                name: name,
                defaultBranchOnly: defaultBranchOnly,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}