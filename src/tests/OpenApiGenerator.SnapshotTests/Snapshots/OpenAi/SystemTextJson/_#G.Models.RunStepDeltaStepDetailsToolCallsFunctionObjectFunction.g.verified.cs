//HintName: G.Models.RunStepDeltaStepDetailsToolCallsFunctionObjectFunction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The definition of the function that was called.
    /// </summary>
    public sealed partial class RunStepDeltaStepDetailsToolCallsFunctionObjectFunction
    {
        /// <summary>
        /// The name of the function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The arguments passed to the function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public string? Arguments { get; set; }

        /// <summary>
        /// The output of the function. This will be `null` if the outputs have not been [submitted](/docs/api-reference/runs/submitToolOutputs) yet.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public string? Output { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}