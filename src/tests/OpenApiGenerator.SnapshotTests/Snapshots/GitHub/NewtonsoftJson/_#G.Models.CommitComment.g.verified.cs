//HintName: G.Models.CommitComment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Commit Comment
    /// </summary>
    public sealed partial class CommitComment
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body", Required = global::Newtonsoft.Json.Required.Always)]
        public string Body { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("path", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Path { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("position", Required = global::Newtonsoft.Json.Required.Always)]
        public int? Position { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("line", Required = global::Newtonsoft.Json.Required.Always)]
        public int? Line { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string CommitId { get; set; } = default!;

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NullableSimpleUser? User { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// How the author is associated with the repository.<br/>
        /// Example: OWNER
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("author_association", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AuthorAssociation? AuthorAssociation { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reactions")]
        public global::G.ReactionRollup? Reactions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}