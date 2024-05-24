//HintName: G.Models.CodeScanningRef.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The Git reference, formatted as `refs/pull/&lt;number&gt;/merge`, `refs/pull/&lt;number&gt;/head`,
    /// `refs/heads/&lt;branch name&gt;` or simply `&lt;branch name&gt;`.
    /// </summary>
    public sealed partial class CodeScanningRef
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}