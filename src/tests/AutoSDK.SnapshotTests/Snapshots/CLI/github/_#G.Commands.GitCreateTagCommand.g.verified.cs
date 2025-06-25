//HintName: G.Commands.GitCreateTagCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GitCreateTagCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            string tag,
            string message,
            string @object,
            global::G.GitCreateTagRequestType type,
            global::G.GitCreateTagRequestTagger? tagger,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GitTag response,
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

        private global::System.CommandLine.Argument<string> Tag { get; } = new(
            name: "tag")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Message { get; } = new(
            name: "message")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Object { get; } = new(
            name: "@object")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::G.GitCreateTagRequestType> Type { get; } = new(
            name: "type")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.GitCreateTagRequestTagger?> Tagger { get; } = new(
            name: "tagger")
        {
            Description = "",
        };
        public GitCreateTagCommand(G.IApi client) : base(
            name: "git",
            description: @"Note that creating a tag object does not create the reference that makes a tag in Git. If you want to create an annotated tag in Git, you have to do this call to create the tag object, and then [create](https://docs.github.com/rest/git/refs#create-a-reference) the `refs/tags/[tag]` reference. If you want to create a lightweight tag, you only have to [create](https://docs.github.com/rest/git/refs#create-a-reference) the tag reference - this call would be unnecessary.

**Signature verification object**

The response will include a `verification` object that describes the result of verifying the commit's signature. The following fields are included in the `verification` object:

| Name | Type | Description |
| ---- | ---- | ----------- |
| `verified` | `boolean` | Indicates whether GitHub considers the signature in this commit to be verified. |
| `reason` | `string` | The reason for verified value. Possible values and their meanings are enumerated in table below. |
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
            Arguments.Add(Tag);
            Arguments.Add(Message);
            Arguments.Add(Object);
            Arguments.Add(Type);
            Options.Add(Tagger);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var tag = parseResult.GetRequiredValue(Tag);
            var message = parseResult.GetRequiredValue(Message);
            var @object = parseResult.GetRequiredValue(Object);
            var type = parseResult.GetRequiredValue(Type);
            var tagger = parseResult.GetRequiredValue(Tagger);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                tag: tag,
                message: message,
                @object: @object,
                type: type,
                tagger: tagger,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Git.GitCreateTagAsync(
                owner: owner,
                repo: repo,
                tag: tag,
                message: message,
                @object: @object,
                type: type,
                tagger: tagger,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}