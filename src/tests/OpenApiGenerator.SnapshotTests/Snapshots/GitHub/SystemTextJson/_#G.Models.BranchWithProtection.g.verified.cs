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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Commit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Commit? Commit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_links")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.BranchWithProtectionLinks Links { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protected")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Protected { get; set; }

        /// <summary>
        /// Branch Protection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protection")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.BranchProtection? Protection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protection_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProtectionUrl { get; set; }

        /// <summary>
        /// Example: "mas*"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pattern")]
        public string? Pattern { get; set; }

        /// <summary>
        /// Example: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_approving_review_count")]
        public int RequiredApprovingReviewCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}