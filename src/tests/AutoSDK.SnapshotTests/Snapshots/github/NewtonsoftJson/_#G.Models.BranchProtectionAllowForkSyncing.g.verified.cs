//HintName: G.Models.BranchProtectionAllowForkSyncing.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Whether users can pull changes from upstream when the branch is locked. Set to `true` to allow fork syncing. Set to `false` to prevent fork syncing.
    /// </summary>
    public sealed partial class BranchProtectionAllowForkSyncing
    {
        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchProtectionAllowForkSyncing" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Default Value: false
        /// </param>
        public BranchProtectionAllowForkSyncing(
            bool? enabled)
        {
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchProtectionAllowForkSyncing" /> class.
        /// </summary>
        public BranchProtectionAllowForkSyncing()
        {
        }
    }
}