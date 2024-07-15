//HintName: G.Models.ReposDeleteFileRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposDeleteFileRequest
    {
        /// <summary>
        /// The commit message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// The blob SHA of the file being deleted.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sha", Required = global::Newtonsoft.Json.Required.Always)]
        public string Sha { get; set; } = default!;

        /// <summary>
        /// The branch name. Default: the repository’s default branch
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("branch")]
        public string? Branch { get; set; }

        /// <summary>
        /// object containing information about the committer.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("committer")]
        public global::G.ReposDeleteFileRequestCommitter? Committer { get; set; }

        /// <summary>
        /// object containing information about the author.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("author")]
        public global::G.ReposDeleteFileRequestAuthor? Author { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}