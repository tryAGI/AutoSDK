//HintName: G.Commands.SecurityAdvisoriesCreateRepositoryAdvisoryCveRequestCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SecurityAdvisoriesCreateRepositoryAdvisoryCveRequestCommand : global::System.CommandLine.Command
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
            string response,
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

        public SecurityAdvisoriesCreateRepositoryAdvisoryCveRequestCommand(G.IApi client) : base(
            name: "security",
            description: @"If you want a CVE identification number for the security vulnerability in your project, and don't already have one, you can request a CVE identification number from GitHub. For more information see ""[Requesting a CVE identification number](https://docs.github.com/code-security/security-advisories/repository-security-advisories/publishing-a-repository-security-advisory#requesting-a-cve-identification-number-optional).""

You may request a CVE for public repositories, but cannot do so for private repositories.

In order to request a CVE for a repository security advisory, the authenticated user must be a security manager or administrator of that repository.

OAuth app tokens and personal access tokens (classic) need the `repo` or `repository_advisories:write` scope to use this endpoint.")
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
            var response = await _client.SecurityAdvisories.SecurityAdvisoriesCreateRepositoryAdvisoryCveRequestAsync(
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