//HintName: G.Models.LangfuseObservabilityPlanMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is a JSON object that will be added to the Langfuse trace. Traces can be enriched with metadata to better understand your users, application, and experiments. https://langfuse.com/docs/tracing-features/metadata<br/>
    /// By default it includes the call metadata, assistant metadata, and assistant overrides.
    /// </summary>
    public sealed partial class LangfuseObservabilityPlanMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}