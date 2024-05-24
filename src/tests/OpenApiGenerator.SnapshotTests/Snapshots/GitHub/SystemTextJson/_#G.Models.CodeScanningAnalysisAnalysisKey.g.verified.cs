//HintName: G.Models.CodeScanningAnalysisAnalysisKey.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Identifies the configuration under which the analysis was executed. For example, in GitHub Actions this includes the workflow filename and job name.
    /// </summary>
    public sealed partial class CodeScanningAnalysisAnalysisKey
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}