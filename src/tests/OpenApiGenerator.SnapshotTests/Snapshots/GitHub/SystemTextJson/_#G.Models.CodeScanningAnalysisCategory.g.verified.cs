//HintName: G.Models.CodeScanningAnalysisCategory.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Identifies the configuration under which the analysis was executed. Used to distinguish between multiple analyses for the same tool and commit, but performed on different languages or different parts of the code.
    /// </summary>
    public sealed partial class CodeScanningAnalysisCategory
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}