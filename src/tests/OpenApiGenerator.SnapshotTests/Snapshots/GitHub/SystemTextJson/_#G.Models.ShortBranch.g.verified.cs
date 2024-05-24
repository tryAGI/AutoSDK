//HintName: G.Models.ShortBranch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Short Branch
    /// </summary>
    public sealed partial class ShortBranch
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required ShortBranchCommit Commit { get; set; }

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
        public BranchProtection? Protection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protection_url")]
        public string? ProtectionUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}