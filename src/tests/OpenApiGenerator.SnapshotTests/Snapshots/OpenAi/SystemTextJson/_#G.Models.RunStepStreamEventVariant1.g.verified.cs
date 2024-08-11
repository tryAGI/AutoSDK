//HintName: G.Models.RunStepStreamEventVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Occurs when a [run step](/docs/api-reference/runs/step-object) is created.
    /// </summary>
    public sealed partial class RunStepStreamEventVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.RunStepStreamEventVariant1EventJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RunStepStreamEventVariant1Event Event { get; set; }

        /// <summary>
        /// Represents a step in execution of a run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RunStepObject Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}