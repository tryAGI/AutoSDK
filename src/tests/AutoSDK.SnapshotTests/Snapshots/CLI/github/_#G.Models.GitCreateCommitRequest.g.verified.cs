//HintName: G.Models.GitCreateCommitRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GitCreateCommitRequest
    {
        /// <summary>
        /// The commit message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// The SHA of the tree object this commit points to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tree")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Tree { get; set; }

        /// <summary>
        /// The full SHAs of the commits that were the parents of this commit. If omitted or empty, the commit will be written as a root commit. For a single parent, an array of one SHA should be provided; for a merge commit, an array of more than one should be provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parents")]
        public global::System.Collections.Generic.IList<string>? Parents { get; set; }

        /// <summary>
        /// Information about the author of the commit. By default, the `author` will be the authenticated user and the current date. See the `author` and `committer` object below for details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        public global::G.GitCreateCommitRequestAuthor? Author { get; set; }

        /// <summary>
        /// Information about the person who is making the commit. By default, `committer` will use the information set in `author`. See the `author` and `committer` object below for details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("committer")]
        public global::G.GitCreateCommitRequestCommitter? Committer { get; set; }

        /// <summary>
        /// The [PGP signature](https://en.wikipedia.org/wiki/Pretty_Good_Privacy) of the commit. GitHub adds the signature to the `gpgsig` header of the created commit. For a commit signature to be verifiable by Git or GitHub, it must be an ASCII-armored detached PGP signature over the string commit as it would be written to the object database. To pass a `signature` parameter, you need to first manually create a valid PGP signature, which can be complicated. You may find it easier to [use the command line](https://git-scm.com/book/id/v2/Git-Tools-Signing-Your-Work) to create signed commits.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signature")]
        public string? Signature { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GitCreateCommitRequest" /> class.
        /// </summary>
        /// <param name="message">
        /// The commit message
        /// </param>
        /// <param name="tree">
        /// The SHA of the tree object this commit points to
        /// </param>
        /// <param name="parents">
        /// The full SHAs of the commits that were the parents of this commit. If omitted or empty, the commit will be written as a root commit. For a single parent, an array of one SHA should be provided; for a merge commit, an array of more than one should be provided.
        /// </param>
        /// <param name="author">
        /// Information about the author of the commit. By default, the `author` will be the authenticated user and the current date. See the `author` and `committer` object below for details.
        /// </param>
        /// <param name="committer">
        /// Information about the person who is making the commit. By default, `committer` will use the information set in `author`. See the `author` and `committer` object below for details.
        /// </param>
        /// <param name="signature">
        /// The [PGP signature](https://en.wikipedia.org/wiki/Pretty_Good_Privacy) of the commit. GitHub adds the signature to the `gpgsig` header of the created commit. For a commit signature to be verifiable by Git or GitHub, it must be an ASCII-armored detached PGP signature over the string commit as it would be written to the object database. To pass a `signature` parameter, you need to first manually create a valid PGP signature, which can be complicated. You may find it easier to [use the command line](https://git-scm.com/book/id/v2/Git-Tools-Signing-Your-Work) to create signed commits.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GitCreateCommitRequest(
            string message,
            string tree,
            global::System.Collections.Generic.IList<string>? parents,
            global::G.GitCreateCommitRequestAuthor? author,
            global::G.GitCreateCommitRequestCommitter? committer,
            string? signature)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Tree = tree ?? throw new global::System.ArgumentNullException(nameof(tree));
            this.Parents = parents;
            this.Author = author;
            this.Committer = committer;
            this.Signature = signature;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GitCreateCommitRequest" /> class.
        /// </summary>
        public GitCreateCommitRequest()
        {
        }
    }
}