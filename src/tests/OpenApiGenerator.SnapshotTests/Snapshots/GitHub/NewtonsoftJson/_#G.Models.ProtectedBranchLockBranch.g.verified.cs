//HintName: G.Models.ProtectedBranchLockBranch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Whether to set the branch as read-only. If this is true, users will not be able to push to the branch.
    /// </summary>
    public sealed partial class ProtectedBranchLockBranch
    {
        /// <summary>
        /// <br/>Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled")]
        public bool Enabled { get; set; } = false;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}