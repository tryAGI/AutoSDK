//HintName: G.Models.BasePromptResolutionGraph.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The dependency resolution graph for the current prompt. Null if the prompt has no dependencies or if `resolve=false` was used.
    /// </summary>
    public sealed partial class BasePromptResolutionGraph
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}