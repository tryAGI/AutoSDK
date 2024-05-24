//HintName: G.Models.CodeScanningRefFull.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The full Git reference, formatted as `refs/heads/&lt;branch name&gt;`,
    /// `refs/tags/&lt;tag&gt;`, `refs/pull/&lt;number&gt;/merge`, or `refs/pull/&lt;number&gt;/head`.
    /// <br/>Example: refs/heads/main
    /// </summary>
    public sealed partial class CodeScanningRefFull
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}