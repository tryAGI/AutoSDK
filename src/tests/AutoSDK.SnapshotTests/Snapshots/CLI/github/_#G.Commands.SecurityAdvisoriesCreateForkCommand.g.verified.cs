//HintName: G.Commands.SecurityAdvisoriesCreateForkCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SecurityAdvisoriesCreateForkCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            string ghsaId,
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

        private global::System.CommandLine.Argument<string> GhsaId { get; } = new(
            name: "ghsaId")
        {
            Description = "",
        };

        public SecurityAdvisoriesCreateForkCommand(G.IApi client) : base(
            name: "security",
            description: @"Create a temporary private fork to collaborate on fixing a security vulnerability in your repository.

> [!NOTE]
> Forking a repository happens asynchronously. You may have to wait up to 5 minutes before you can access the fork.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(GhsaId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var ghsaId = parseResult.GetRequiredValue(GhsaId);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                ghsaId: ghsaId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.SecurityAdvisories.SecurityAdvisoriesCreateForkAsync(
                owner: owner,
                repo: repo,
                ghsaId: ghsaId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}