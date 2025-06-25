//HintName: G.Models.BranchProtectionLockBranch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Whether to set the branch as read-only. If this is true, users will not be able to push to the branch.
    /// </summary>
    public sealed partial class BranchProtectionLockBranch
    {
        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchProtectionLockBranch" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BranchProtectionLockBranch(
            bool? enabled)
        {
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchProtectionLockBranch" /> class.
        /// </summary>
        public BranchProtectionLockBranch()
        {
        }
    }
}