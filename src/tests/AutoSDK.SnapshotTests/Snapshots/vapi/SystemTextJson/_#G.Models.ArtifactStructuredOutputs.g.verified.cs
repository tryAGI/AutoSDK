//HintName: G.Models.ArtifactStructuredOutputs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// These are the structured outputs that will be extracted from the call.<br/>
    /// To enable, set `assistant.artifactPlan.structuredOutputIds` with the IDs of the structured outputs you want to extract.
    /// </summary>
    public sealed partial class ArtifactStructuredOutputs
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}