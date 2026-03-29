//HintName: G.Models.LlamaParseJobFailureConditionsAllowedPageFailureRatio.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Maximum ratio of pages allowed to fail before the job fails (0-1). Example: 0.1 means job fails if more than 10% of pages fail. Default is 0.05 (5%)
    /// </summary>
    public sealed partial class LlamaParseJobFailureConditionsAllowedPageFailureRatio
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}