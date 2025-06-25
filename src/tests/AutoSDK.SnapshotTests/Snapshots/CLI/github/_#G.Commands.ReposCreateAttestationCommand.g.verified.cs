//HintName: G.Commands.ReposCreateAttestationCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReposCreateAttestationCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            global::G.ReposCreateAttestationRequestBundle bundle,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ReposCreateAttestationResponse response,
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

        private global::System.CommandLine.Argument<global::G.ReposCreateAttestationRequestBundle> Bundle { get; } = new(
            name: "bundle")
        {
            Description = "",
        };

        public ReposCreateAttestationCommand(G.IApi client) : base(
            name: "repos",
            description: @"Store an artifact attestation and associate it with a repository.

The authenticated user must have write permission to the repository and, if using a fine-grained access token, the `attestations:write` permission is required.

Artifact attestations are meant to be created using the [attest action](https://github.com/actions/attest). For more information, see our guide on [using artifact attestations to establish a build's provenance](https://docs.github.com/actions/security-guides/using-artifact-attestations-to-establish-provenance-for-builds).")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(Bundle);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var bundle = parseResult.GetRequiredValue(Bundle);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                bundle: bundle,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Repos.ReposCreateAttestationAsync(
                owner: owner,
                repo: repo,
                bundle: bundle,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}