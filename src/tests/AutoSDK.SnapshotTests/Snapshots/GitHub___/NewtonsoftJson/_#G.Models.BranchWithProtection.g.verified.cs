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
        /// <example>"mas*"</example>
        [global::Newtonsoft.Json.JsonProperty("pattern")]
        public string? Pattern { get; set; }

        /// <summary>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("required_approving_review_count")]
        public int? RequiredApprovingReviewCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchWithProtection" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="commit">
        /// Commit
        /// </param>
        /// <param name="links"></param>
        /// <param name="protected"></param>
        /// <param name="protection">
        /// Branch Protection
        /// </param>
        /// <param name="protectionUrl"></param>
        /// <param name="pattern">
        /// Example: "mas*"
        /// </param>
        /// <param name="requiredApprovingReviewCount">
        /// Example: 1
        /// </param>
        public BranchWithProtection(
            string name,
            global::G.Commit commit,
            global::G.BranchWithProtectionLinks links,
            bool @protected,
            global::G.BranchProtection protection,
            string protectionUrl,
            string? pattern,
            int? requiredApprovingReviewCount)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Commit = commit ?? throw new global::System.ArgumentNullException(nameof(commit));
            this.Links = links ?? throw new global::System.ArgumentNullException(nameof(links));
            this.Protected = @protected;
            this.Protection = protection ?? throw new global::System.ArgumentNullException(nameof(protection));
            this.ProtectionUrl = protectionUrl ?? throw new global::System.ArgumentNullException(nameof(protectionUrl));
            this.Pattern = pattern;
            this.RequiredApprovingReviewCount = requiredApprovingReviewCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchWithProtection" /> class.
        /// </summary>
        public BranchWithProtection()
        {
        }
    }
}