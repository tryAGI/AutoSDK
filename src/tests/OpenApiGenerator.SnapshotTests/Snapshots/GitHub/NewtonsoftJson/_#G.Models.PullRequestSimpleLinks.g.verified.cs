//HintName: G.Models.PullRequestSimpleLinks.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PullRequestSimpleLinks
    {
        /// <summary>
        /// Hypermedia Link
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("comments", Required = global::Newtonsoft.Json.Required.Always)]
        public Link Comments { get; set; } = default!;

        /// <summary>
        /// Hypermedia Link
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commits", Required = global::Newtonsoft.Json.Required.Always)]
        public Link Commits { get; set; } = default!;

        /// <summary>
        /// Hypermedia Link
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("statuses", Required = global::Newtonsoft.Json.Required.Always)]
        public Link Statuses { get; set; } = default!;

        /// <summary>
        /// Hypermedia Link
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html", Required = global::Newtonsoft.Json.Required.Always)]
        public Link Html { get; set; } = default!;

        /// <summary>
        /// Hypermedia Link
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("issue", Required = global::Newtonsoft.Json.Required.Always)]
        public Link Issue { get; set; } = default!;

        /// <summary>
        /// Hypermedia Link
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("review_comments", Required = global::Newtonsoft.Json.Required.Always)]
        public Link ReviewComments { get; set; } = default!;

        /// <summary>
        /// Hypermedia Link
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("review_comment", Required = global::Newtonsoft.Json.Required.Always)]
        public Link ReviewComment { get; set; } = default!;

        /// <summary>
        /// Hypermedia Link
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("self", Required = global::Newtonsoft.Json.Required.Always)]
        public Link Self { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}