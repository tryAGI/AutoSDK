//HintName: G.Models.LlamaParseJobFailureConditionsFailOnBuggyFont.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Fail the job if a problematic font is detected that may cause incorrect text extraction. Buggy fonts can produce garbled or missing characters
    /// </summary>
    public sealed partial class LlamaParseJobFailureConditionsFailOnBuggyFont
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}