//HintName: G.Commands.GitCreateCommitCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GitCreateCommitCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            string message,
            string tree,
            global::System.Collections.Generic.IList<string>? parents,
            global::G.GitCreateCommitRequestAuthor? author,
            global::G.GitCreateCommitRequestCommitter? committer,
            string? signature,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GitCommit response,
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

        private global::System.CommandLine.Argument<string> Message { get; } = new(
            name: "message")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Tree { get; } = new(
            name: "tree")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Parents { get; } = new(
            name: "parents")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.GitCreateCommitRequestAuthor?> Author { get; } = new(
            name: "author")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.GitCreateCommitRequestCommitter?> Committer { get; } = new(
            name: "committer")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Signature { get; } = new(
            name: "signature")
        {
            Description = "",
        };
        public GitCreateCommitCommand(G.IApi client) : base(
            name: "git",
            description: @"Creates a new Git [commit object](https://git-scm.com/book/en/v2/Git-Internals-Git-Objects).

**Signature verification object**

The response will include a `verification` object that describes the result of verifying the commit's signature. The following fields are included in the `verification` object:

| Name | Type | Description |
| ---- | ---- | ----------- |
| `verified` | `boolean` | Indicates whether GitHub considers the signature in this commit to be verified. |
| `reason` | `string` | The reason for verified value. Possible values and their meanings are enumerated in the table below. |
| `signature` | `string` | The signature that was extracted from the commit. |
| `payload` | `string` | The value that was signed. |

These are the possible values for `reason` in the `verification` object:

| Value | Description |
| ----- | ----------- |
| `expired_key` | The key that made the signature is expired. |
| `not_signing_key` | The ""signing"" flag is not among the usage flags in the GPG key that made the signature. |
| `gpgverify_error` | There was an error communicating with the signature verification service. |
| `gpgverify_unavailable` | The signature verification service is currently unavailable. |
| `unsigned` | The object does not include a signature. |
| `unknown_signature_type` | A non-PGP signature was found in the commit. |
| `no_user` | No user was associated with the `committer` email address in the commit. |
| `unverified_email` | The `committer` email address in the commit was associated with a user, but the email address is not verified on their account. |
| `bad_email` | The `committer` email address in the commit is not included in the identities of the PGP key that made the signature. |
| `unknown_key` | The key that made the signature has not been registered with any user's account. |
| `malformed_signature` | There was an error parsing the signature. |
| `invalid` | The signature could not be cryptographically verified using the key whose key-id was found in the signature. |
| `valid` | None of the above errors applied, so the signature is considered to be verified. |")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(Message);
            Arguments.Add(Tree);
            Options.Add(Parents);
            Options.Add(Author);
            Options.Add(Committer);
            Options.Add(Signature);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var message = parseResult.GetRequiredValue(Message);
            var tree = parseResult.GetRequiredValue(Tree);
            var parents = parseResult.GetRequiredValue(Parents);
            var author = parseResult.GetRequiredValue(Author);
            var committer = parseResult.GetRequiredValue(Committer);
            var signature = parseResult.GetRequiredValue(Signature);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                message: message,
                tree: tree,
                parents: parents,
                author: author,
                committer: committer,
                signature: signature,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Git.GitCreateCommitAsync(
                owner: owner,
                repo: repo,
                message: message,
                tree: tree,
                parents: parents,
                author: author,
                committer: committer,
                signature: signature,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}