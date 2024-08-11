//HintName: G.Models.PullRequestLinks.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PullRequestLinks
    {
        /// <summary>
        /// Hypermedia Link
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("comments", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Link Comments { get; set; } = default!;

        /// <summary>
        /// Hypermedia Link
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commits", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Link Commits { get; set; } = default!;

        /// <summary>
        /// Hypermedia Link
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("statuses", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Link Statuses { get; set; } = default!;

        /// <summary>
        /// Hypermedia Link
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Link Html { get; set; } = default!;

        /// <summary>
        /// Hypermedia Link
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("issue", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Link Issue { get; set; } = default!;

        /// <summary>
        /// Hypermedia Link
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("review_comments", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Link ReviewComments { get; set; } = default!;

        /// <summary>
        /// Hypermedia Link
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("review_comment", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Link ReviewComment { get; set; } = default!;

        /// <summary>
        /// Hypermedia Link
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("self", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Link Self { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}