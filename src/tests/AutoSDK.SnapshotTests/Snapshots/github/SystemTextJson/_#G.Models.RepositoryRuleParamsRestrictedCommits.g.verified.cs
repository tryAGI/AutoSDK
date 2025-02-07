//HintName: G.Models.RepositoryRuleParamsRestrictedCommits.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Restricted commit
    /// </summary>
    public sealed partial class RepositoryRuleParamsRestrictedCommits
    {
        /// <summary>
        /// Full or abbreviated commit hash to reject
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Oid { get; set; }

        /// <summary>
        /// Reason for restriction
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleParamsRestrictedCommits" /> class.
        /// </summary>
        /// <param name="oid">
        /// Full or abbreviated commit hash to reject
        /// </param>
        /// <param name="reason">
        /// Reason for restriction
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RepositoryRuleParamsRestrictedCommits(
            string oid,
            string? reason)
        {
            this.Oid = oid ?? throw new global::System.ArgumentNullException(nameof(oid));
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleParamsRestrictedCommits" /> class.
        /// </summary>
        public RepositoryRuleParamsRestrictedCommits()
        {
        }
    }
}