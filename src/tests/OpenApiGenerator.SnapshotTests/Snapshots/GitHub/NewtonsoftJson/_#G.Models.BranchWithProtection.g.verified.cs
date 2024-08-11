//HintName: G.Models.BranchWithProtection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Branch With Protection
    /// </summary>
    public sealed partial class BranchWithProtection
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Commit
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Commit Commit { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("_links", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.BranchWithProtectionLinks Links { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("protected", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Protected { get; set; } = default!;

        /// <summary>
        /// Branch Protection
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("protection", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.BranchProtection Protection { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("protection_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProtectionUrl { get; set; } = default!;

        /// <summary>
        /// Example: "mas*"
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pattern")]
        public string? Pattern { get; set; }

        /// <summary>
        /// Example: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required_approving_review_count")]
        public int RequiredApprovingReviewCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}